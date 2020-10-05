// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class XPosition : OpenXmlLeafTextElement
  {
    private const string tagName = "x";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10674;

    public override string LocalName
    {
      get
      {
        return "x";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 12;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10674;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public XPosition()
    {
    }

    public XPosition(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      DoubleValue doubleValue = new DoubleValue();
      doubleValue.InnerText = text;
      return (OpenXmlSimpleType) doubleValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<XPosition>(deep);
    }
  }
}
