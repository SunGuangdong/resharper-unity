using System;
using System.Linq;
using System.Reflection;
using JetBrains.Platform.RdFramework.Base;
using JetBrains.Platform.RdFramework.Util;
using JetBrains.Platform.Unity.EditorPluginModel;
using JetBrains.Util;
using JetBrains.Util.Logging;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace JetBrains.Rider.Unity.Editor.Navigation
{
  [InitializeOnLoad]
  public static class EntryPoint
  {
    private static readonly ILog ourLogger = Log.GetLog("UnitTesting.EntryPoint");
    
    static EntryPoint()
    {
      if (!PluginEntryPoint.Enabled)
        return;
      ourLogger.Verbose("UnitTesting.EntryPoint");

      PluginEntryPoint.OnModelInitialization += OnModelInitializationHandler;
      AppDomain.CurrentDomain.DomainUnload += (EventHandler) ((_, __) =>
      {
        PluginEntryPoint.OnModelInitialization -= OnModelInitializationHandler;
      });
    }
    
    
    private static void OnModelInitializationHandler(UnityModelAndLifetime modelAndLifetime)
    {
      var modelValue = modelAndLifetime.Model;
      var connectionLifetime = modelAndLifetime.Lifetime;
      modelValue.ShowGameObjectOnScene.Advise(connectionLifetime,  findUsagesResult =>
      {
        if (findUsagesResult == null)
          return;
        
        MainThreadDispatcher.Instance.Queue(() =>
        {
          if (findUsagesResult.IsPrefab)
          {
            ShowUtil.ShowPrefabUsage(findUsagesResult.FilePath, findUsagesResult.PathElements);
          }
          else
          {
            ShowUtil.ShowUsageOnScene(findUsagesResult.FilePath,  findUsagesResult.FileName, findUsagesResult.PathElements, findUsagesResult.RootIndices);
          }
        });
      });
      
      modelValue.FindUsageResults.Advise(connectionLifetime, result =>
      {
        if (result == null)
          return;

        MainThreadDispatcher.Instance.Queue(() =>
        {
          GUI.BringWindowToFront(EditorWindow.GetWindow<SceneView>().GetInstanceID());
          GUI.BringWindowToFront(EditorWindow.GetWindow(typeof(SceneView).Assembly.GetType("UnityEditor.SceneHierarchyWindow")).GetInstanceID());      
          GUI.BringWindowToFront(EditorWindow.GetWindow(typeof(SceneView).Assembly.GetType("UnityEditor.ProjectBrowser")).GetInstanceID());

          var window = FindUsagesWindow.GetWindow(result.Target);
          window.SetDataToEditor(result.Elements);
        });
      });
    }
  }
}