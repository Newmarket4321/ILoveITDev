// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class ChartLinesType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "spPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 11
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ChartLinesType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ChartLinesType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(0);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(0, value);
      }
    }

    protected ChartLinesType()
    {
    }

    protected ChartLinesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected ChartLinesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected ChartLinesType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
