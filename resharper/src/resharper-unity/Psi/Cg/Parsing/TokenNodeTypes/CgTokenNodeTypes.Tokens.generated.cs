﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by TokenGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Plugins.Unity.Psi.Cg.Parsing.TokenNodeTypes
{
  public partial class CgTokenNodeTypes
  {
    //Tokens
    public const int LBRACE_NODE_TYPE_INDEX = 1000;
    public static readonly TokenNodeType LBRACE = new CgFixedLengthTokenNodeType("LBRACE", LBRACE_NODE_TYPE_INDEX, representation: "{");
    public const int RBRACE_NODE_TYPE_INDEX = 1001;
    public static readonly TokenNodeType RBRACE = new CgFixedLengthTokenNodeType("RBRACE", RBRACE_NODE_TYPE_INDEX, representation: "}");
    public const int SEMICOLON_NODE_TYPE_INDEX = 1002;
    public static readonly TokenNodeType SEMICOLON = new CgFixedLengthTokenNodeType("SEMICOLON", SEMICOLON_NODE_TYPE_INDEX, representation: ";");

    //FieldTypeKeywords
    public const int BOOL_KEYWORD_NODE_TYPE_INDEX = 1003;
    public static readonly TokenNodeType BOOL_KEYWORD = new CgKeywordTokenNodeType("BOOL_KEYWORD", BOOL_KEYWORD_NODE_TYPE_INDEX, representation: "bool");
    public const int INT_KEYWORD_NODE_TYPE_INDEX = 1004;
    public static readonly TokenNodeType INT_KEYWORD = new CgKeywordTokenNodeType("INT_KEYWORD", INT_KEYWORD_NODE_TYPE_INDEX, representation: "int");
    public const int UINT_KEYWORD_NODE_TYPE_INDEX = 1005;
    public static readonly TokenNodeType UINT_KEYWORD = new CgKeywordTokenNodeType("UINT_KEYWORD", UINT_KEYWORD_NODE_TYPE_INDEX, representation: "uint");
    public const int DWORD_KEYWORD_NODE_TYPE_INDEX = 1006;
    public static readonly TokenNodeType DWORD_KEYWORD = new CgKeywordTokenNodeType("DWORD_KEYWORD", DWORD_KEYWORD_NODE_TYPE_INDEX, representation: "dword");
    public const int HALF_KEYWORD_NODE_TYPE_INDEX = 1007;
    public static readonly TokenNodeType HALF_KEYWORD = new CgKeywordTokenNodeType("HALF_KEYWORD", HALF_KEYWORD_NODE_TYPE_INDEX, representation: "half");
    public const int FLOAT_KEYWORD_NODE_TYPE_INDEX = 1008;
    public static readonly TokenNodeType FLOAT_KEYWORD = new CgKeywordTokenNodeType("FLOAT_KEYWORD", FLOAT_KEYWORD_NODE_TYPE_INDEX, representation: "float");
    public const int DOUBLE_KEYWORD_NODE_TYPE_INDEX = 1009;
    public static readonly TokenNodeType DOUBLE_KEYWORD = new CgKeywordTokenNodeType("DOUBLE_KEYWORD", DOUBLE_KEYWORD_NODE_TYPE_INDEX, representation: "double");

    //TypeDeclarationKeywords
    public const int STRUCT_KEYWORD_NODE_TYPE_INDEX = 1010;
    public static readonly TokenNodeType STRUCT_KEYWORD = new CgKeywordTokenNodeType("STRUCT_KEYWORD", STRUCT_KEYWORD_NODE_TYPE_INDEX, representation: "struct");

    private const int LAST_GENERATED_TOKEN_TYPE_INDEX = 1011;  }
}