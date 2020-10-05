// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.TraceView
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (AnnotationXml))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Annotation))]
  [ChildElementInfo(typeof (TraceView))]
  public class TraceView : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "id",
      "contextRef",
      "traceDataRef",
      "from",
      "to"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "traceView";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12738;

    public override string LocalName
    {
      get
      {
        return "traceView";
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
        return 12738;
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
        return TraceView.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TraceView.attributeNamespaceIds;
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

    [SchemaAttr(0, "traceDataRef")]
    public StringValue TraceDataRef
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

    [SchemaAttr(0, "from")]
    public StringValue From
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

    [SchemaAttr(0, "to")]
    public StringValue To
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

    public TraceView()
    {
    }

    public TraceView(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TraceView(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TraceView(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "annotation" == name)
        return (OpenXmlElement) new Annotation();
      if (43 == (int) namespaceId && "annotationXML" == name)
        return (OpenXmlElement) new AnnotationXml();
      if (43 == (int) namespaceId && "traceView" == name)
        return (OpenXmlElement) new TraceView();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "contextRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "traceDataRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "from" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "to" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TraceView>(deep);
    }
  }
}
