// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ExtendedProperties.SharedDocument
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
  [GeneratedCode("DomGen", "2.0")]
  public class SharedDocument : OpenXmlLeafTextElement
  {
    private const string tagName = "SharedDoc";
    private const byte tagNsId = 3;
    internal const int ElementTypeIdConst = 11084;

    public override string LocalName
    {
      get
      {
        return "SharedDoc";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 3;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11084;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SharedDocument()
    {
    }

    public SharedDocument(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      BooleanValue booleanValue = new BooleanValue();
      booleanValue.InnerText = text;
      return (OpenXmlSimpleType) booleanValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SharedDocument>(deep);
    }
  }
}
