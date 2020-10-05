// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.VariantTypes.VTFloat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.VariantTypes
{
  [GeneratedCode("DomGen", "2.0")]
  public class VTFloat : OpenXmlLeafTextElement
  {
    private const string tagName = "r4";
    private const byte tagNsId = 5;
    internal const int ElementTypeIdConst = 11046;

    public override string LocalName
    {
      get
      {
        return "r4";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 5;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11046;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public VTFloat()
    {
    }

    public VTFloat(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      SingleValue singleValue = new SingleValue();
      singleValue.InnerText = text;
      return (OpenXmlSimpleType) singleValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VTFloat>(deep);
    }
  }
}
