using System.Collections.Generic;
using JetBrains.Application.UI.Controls.GotoByName;
using JetBrains.ProjectModel;
using JetBrains.Rider.Model;

namespace JetBrains.ReSharper.Plugins.Unity.Rider.CodeInsights
{
    [SolutionComponent]
    public class UnityCodeInsightFieldUsageProvider : AbstractUnityCodeInsightProvider
    {
        public override string ProviderId => "Unity serialized field";
        public override string DisplayName => "Unity serialized field";
        public override CodeLensAnchorKind DefaultAnchor => CodeLensAnchorKind.Right;
        public override ICollection<CodeLensRelativeOrdering> RelativeOrderings => new [] {new CodeLensRelativeOrderingLast()};

        public UnityCodeInsightFieldUsageProvider(UnityHost host, BulbMenuComponent bulbMenu)
            : base(host, bulbMenu)
        {
        }
    }
}