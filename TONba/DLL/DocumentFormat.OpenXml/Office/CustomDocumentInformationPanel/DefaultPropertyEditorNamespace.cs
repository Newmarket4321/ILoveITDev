// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel.DefaultPropertyEditorNamespace
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
  [GeneratedCode("DomGen", "2.0")]
  public class DefaultPropertyEditorNamespace : OpenXmlLeafTextElement
  {
    private const string tagName = "defaultPropertyEditorNamespace";
    private const byte tagNsId = 37;
    internal const int ElementTypeIdConst = 12703;

    public override string LocalName
    {
      get
      {
        return "defaultPropertyEditorNamespace";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 37;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12703;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DefaultPropertyEditorNamespace()
    {
    }

    public DefaultPropertyEditorNamespace(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DefaultPropertyEditorNamespace>(deep);
    }
  }
}
