// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [ChildElementInfo(typeof (XPosition))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (YPosition))]
  public abstract class MarkerType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "x",
      "y"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 12,
      (byte) 12
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "x" == name)
        return (OpenXmlElement) new XPosition();
      if (12 == (int) namespaceId && "y" == name)
        return (OpenXmlElement) new YPosition();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MarkerType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MarkerType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public XPosition XPosition
    {
      get
      {
        return this.GetElement<XPosition>(0);
      }
      set
      {
        this.SetElement<XPosition>(0, value);
      }
    }

    public YPosition YPosition
    {
      get
      {
        return this.GetElement<YPosition>(1);
      }
      set
      {
        this.SetElement<YPosition>(1, value);
      }
    }

    protected MarkerType()
    {
    }

    protected MarkerType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected MarkerType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected MarkerType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
