// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.SourceType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Bibliography
{
  [GeneratedCode("DomGen", "2.0")]
  public class SourceType : OpenXmlLeafTextElement
  {
    private const string tagName = "SourceType";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10884;

    public override string LocalName
    {
      get
      {
        return nameof (SourceType);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10884;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SourceType()
    {
    }

    public SourceType(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      EnumValue<DataSourceValues> enumValue = new EnumValue<DataSourceValues>();
      enumValue.InnerText = text;
      return (OpenXmlSimpleType) enumValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SourceType>(deep);
    }
  }
}
