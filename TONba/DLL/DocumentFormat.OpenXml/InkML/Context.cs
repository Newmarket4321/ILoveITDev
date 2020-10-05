// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Context
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Canvas))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TraceFormat))]
  [ChildElementInfo(typeof (CanvasTransform))]
  [ChildElementInfo(typeof (InkSource))]
  [ChildElementInfo(typeof (Brush))]
  [ChildElementInfo(typeof (Timestamp))]
  public class Context : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "id",
      "contextRef",
      "canvasRef",
      "canvasTransformRef",
      "traceFormatRef",
      "inkSourceRef",
      "brushRef",
      "timestampRef"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[6]
    {
      "canvas",
      "canvasTransform",
      "traceFormat",
      "inkSource",
      "brush",
      "timestamp"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 43,
      (byte) 43,
      (byte) 43,
      (byte) 43,
      (byte) 43,
      (byte) 43
    };
    private const string tagName = "context";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12739;

    public override string LocalName
    {
      get
      {
        return "context";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12739;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Context.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Context.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "canvasRef")]
    public StringValue CanvasRef
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "canvasTransformRef")]
    public StringValue CanvasTransformRef
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "traceFormatRef")]
    public StringValue TraceFromatRef
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "inkSourceRef")]
    public StringValue InkSourceRef
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "timestampRef")]
    public StringValue TimestampRef
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public Context()
    {
    }

    public Context(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Context(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Context(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "canvas" == name)
        return (OpenXmlElement) new Canvas();
      if (43 == (int) namespaceId && "canvasTransform" == name)
        return (OpenXmlElement) new CanvasTransform();
      if (43 == (int) namespaceId && "traceFormat" == name)
        return (OpenXmlElement) new TraceFormat();
      if (43 == (int) namespaceId && "inkSource" == name)
        return (OpenXmlElement) new InkSource();
      if (43 == (int) namespaceId && "brush" == name)
        return (OpenXmlElement) new Brush();
      if (43 == (int) namespaceId && "timestamp" == name)
        return (OpenXmlElement) new Timestamp();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Context.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Context.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Canvas Canvas
    {
      get
      {
        return this.GetElement<Canvas>(0);
      }
      set
      {
        this.SetElement<Canvas>(0, value);
      }
    }

    public CanvasTransform CanvasTransform
    {
      get
      {
        return this.GetElement<CanvasTransform>(1);
      }
      set
      {
        this.SetElement<CanvasTransform>(1, value);
      }
    }

    public TraceFormat TraceFormat
    {
      get
      {
        return this.GetElement<TraceFormat>(2);
      }
      set
      {
        this.SetElement<TraceFormat>(2, value);
      }
    }

    public InkSource InkSource
    {
      get
      {
        return this.GetElement<InkSource>(3);
      }
      set
      {
        this.SetElement<InkSource>(3, value);
      }
    }

    public Brush Brush
    {
      get
      {
        return this.GetElement<Brush>(4);
      }
      set
      {
        this.SetElement<Brush>(4, value);
      }
    }

    public Timestamp Timestamp
    {
      get
      {
        return this.GetElement<Timestamp>(5);
      }
      set
      {
        this.SetElement<Timestamp>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "contextRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "canvasRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "canvasTransformRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "traceFormatRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "inkSourceRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "brushRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "timestampRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Context>(deep);
    }
  }
}
