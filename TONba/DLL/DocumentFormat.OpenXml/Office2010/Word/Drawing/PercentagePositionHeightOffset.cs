// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class PercentagePositionHeightOffset : OpenXmlLeafTextElement
  {
    private const string tagName = "pctPosHOffset";
    private const byte tagNsId = 51;
    internal const int ElementTypeIdConst = 12889;

    public override string LocalName
    {
      get
      {
        return "pctPosHOffset";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 51;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12889;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PercentagePositionHeightOffset()
    {
    }

    public PercentagePositionHeightOffset(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      Int32Value int32Value = new Int32Value();
      int32Value.InnerText = text;
      return (OpenXmlSimpleType) int32Value;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PercentagePositionHeightOffset>(deep);
    }
  }
}
