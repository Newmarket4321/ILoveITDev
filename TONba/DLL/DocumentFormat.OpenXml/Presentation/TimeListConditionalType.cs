// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeListConditionalType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TargetElement))]
  [ChildElementInfo(typeof (RuntimeNodeTrigger))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TimeNode))]
  public abstract class TimeListConditionalType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "evt",
      "delay"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "tgtEl",
      "tn",
      "rtn"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return TimeListConditionalType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TimeListConditionalType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "evt")]
    public EnumValue<TriggerEventValues> Event
    {
      get
      {
        return (EnumValue<TriggerEventValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "delay")]
    public StringValue Delay
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tgtEl" == name)
        return (OpenXmlElement) new TargetElement();
      if (24 == (int) namespaceId && "tn" == name)
        return (OpenXmlElement) new TimeNode();
      if (24 == (int) namespaceId && "rtn" == name)
        return (OpenXmlElement) new RuntimeNodeTrigger();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TimeListConditionalType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TimeListConditionalType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public TargetElement TargetElement
    {
      get
      {
        return this.GetElement<TargetElement>(0);
      }
      set
      {
        this.SetElement<TargetElement>(0, value);
      }
    }

    public TimeNode TimeNode
    {
      get
      {
        return this.GetElement<TimeNode>(1);
      }
      set
      {
        this.SetElement<TimeNode>(1, value);
      }
    }

    public RuntimeNodeTrigger RuntimeNodeTrigger
    {
      get
      {
        return this.GetElement<RuntimeNodeTrigger>(2);
      }
      set
      {
        this.SetElement<RuntimeNodeTrigger>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "evt" == name)
        return (OpenXmlSimpleType) new EnumValue<TriggerEventValues>();
      if ((int) namespaceId == 0 && "delay" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected TimeListConditionalType()
    {
    }

    protected TimeListConditionalType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TimeListConditionalType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TimeListConditionalType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
