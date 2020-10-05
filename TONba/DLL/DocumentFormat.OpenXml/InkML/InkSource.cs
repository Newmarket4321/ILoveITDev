// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.InkSource
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Latency))]
  [ChildElementInfo(typeof (ChannelProperties))]
  [ChildElementInfo(typeof (SourceProperty))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ActiveArea))]
  [ChildElementInfo(typeof (TraceFormat))]
  [ChildElementInfo(typeof (SampleRate))]
  public class InkSource : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "id",
      "manufacturer",
      "model",
      "serialNo",
      "specificationRef",
      "description"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[6]
    {
      "traceFormat",
      "sampleRate",
      "latency",
      "activeArea",
      "srcProperty",
      "channelProperties"
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
    private const string tagName = "inkSource";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12733;

    public override string LocalName
    {
      get
      {
        return "inkSource";
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
        return 12733;
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
        return InkSource.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return InkSource.attributeNamespaceIds;
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

    [SchemaAttr(0, "manufacturer")]
    public StringValue Manufacturer
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

    [SchemaAttr(0, "model")]
    public StringValue Model
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

    [SchemaAttr(0, "serialNo")]
    public StringValue SerialNo
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

    [SchemaAttr(0, "specificationRef")]
    public StringValue SpecificationRef
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

    [SchemaAttr(0, "description")]
    public StringValue Description
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

    public InkSource()
    {
    }

    public InkSource(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public InkSource(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public InkSource(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "traceFormat" == name)
        return (OpenXmlElement) new TraceFormat();
      if (43 == (int) namespaceId && "sampleRate" == name)
        return (OpenXmlElement) new SampleRate();
      if (43 == (int) namespaceId && "latency" == name)
        return (OpenXmlElement) new Latency();
      if (43 == (int) namespaceId && "activeArea" == name)
        return (OpenXmlElement) new ActiveArea();
      if (43 == (int) namespaceId && "srcProperty" == name)
        return (OpenXmlElement) new SourceProperty();
      if (43 == (int) namespaceId && "channelProperties" == name)
        return (OpenXmlElement) new ChannelProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return InkSource.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return InkSource.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TraceFormat TraceFormat
    {
      get
      {
        return this.GetElement<TraceFormat>(0);
      }
      set
      {
        this.SetElement<TraceFormat>(0, value);
      }
    }

    public SampleRate SampleRate
    {
      get
      {
        return this.GetElement<SampleRate>(1);
      }
      set
      {
        this.SetElement<SampleRate>(1, value);
      }
    }

    public Latency Latency
    {
      get
      {
        return this.GetElement<Latency>(2);
      }
      set
      {
        this.SetElement<Latency>(2, value);
      }
    }

    public ActiveArea ActiveArea
    {
      get
      {
        return this.GetElement<ActiveArea>(3);
      }
      set
      {
        this.SetElement<ActiveArea>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "manufacturer" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "model" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "serialNo" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "specificationRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<InkSource>(deep);
    }
  }
}
