// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonTimeNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Iterate))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EndConditionList))]
  [ChildElementInfo(typeof (EndSync))]
  [ChildElementInfo(typeof (SubTimeNodeList))]
  [ChildElementInfo(typeof (StartConditionList))]
  [ChildElementInfo(typeof (ChildTimeNodeList))]
  public class CommonTimeNode : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[24]
    {
      "id",
      "presetID",
      "presetClass",
      "presetSubtype",
      "dur",
      "repeatCount",
      "repeatDur",
      "spd",
      "accel",
      "decel",
      "autoRev",
      "restart",
      "fill",
      "syncBehavior",
      "tmFilter",
      "evtFilter",
      "display",
      "masterRel",
      "bldLvl",
      "grpId",
      "afterEffect",
      "nodeType",
      "nodePh",
      "presetBounceEnd"
    };
    private static byte[] attributeNamespaceIds = new byte[24]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 49
    };
    private static readonly string[] eleTagNames = new string[6]
    {
      "stCondLst",
      "endCondLst",
      "endSync",
      "iterate",
      "childTnLst",
      "subTnLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cTn";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12272;

    public override string LocalName
    {
      get
      {
        return "cTn";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12272;
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
        return CommonTimeNode.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonTimeNode.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "presetID")]
    public Int32Value PresetId
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "presetClass")]
    public EnumValue<TimeNodePresetClassValues> PresetClass
    {
      get
      {
        return (EnumValue<TimeNodePresetClassValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "presetSubtype")]
    public Int32Value PresetSubtype
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dur")]
    public StringValue Duration
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

    [SchemaAttr(0, "repeatCount")]
    public StringValue RepeatCount
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

    [SchemaAttr(0, "repeatDur")]
    public StringValue RepeatDuration
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

    [SchemaAttr(0, "spd")]
    public Int32Value Speed
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "accel")]
    public Int32Value Acceleration
    {
      get
      {
        return (Int32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "decel")]
    public Int32Value Deceleration
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoRev")]
    public BooleanValue AutoReverse
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "restart")]
    public EnumValue<TimeNodeRestartValues> Restart
    {
      get
      {
        return (EnumValue<TimeNodeRestartValues>) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fill")]
    public EnumValue<TimeNodeFillValues> Fill
    {
      get
      {
        return (EnumValue<TimeNodeFillValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "syncBehavior")]
    public EnumValue<TimeNodeSyncValues> SyncBehavior
    {
      get
      {
        return (EnumValue<TimeNodeSyncValues>) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tmFilter")]
    public StringValue TimeFilter
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "evtFilter")]
    public StringValue EventFilter
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "display")]
    public BooleanValue Display
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "masterRel")]
    public EnumValue<TimeNodeMasterRelationValues> MasterRelation
    {
      get
      {
        return (EnumValue<TimeNodeMasterRelationValues>) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bldLvl")]
    public Int32Value BuildLevel
    {
      get
      {
        return (Int32Value) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "grpId")]
    public UInt32Value GroupId
    {
      get
      {
        return (UInt32Value) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "afterEffect")]
    public BooleanValue AfterEffect
    {
      get
      {
        return (BooleanValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "nodeType")]
    public EnumValue<TimeNodeValues> NodeType
    {
      get
      {
        return (EnumValue<TimeNodeValues>) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "nodePh")]
    public BooleanValue NodePlaceholder
    {
      get
      {
        return (BooleanValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(49, "presetBounceEnd")]
    public Int32Value PresetBounceEnd
    {
      get
      {
        return (Int32Value) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    public CommonTimeNode()
    {
    }

    public CommonTimeNode(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonTimeNode(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonTimeNode(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "stCondLst" == name)
        return (OpenXmlElement) new StartConditionList();
      if (24 == (int) namespaceId && "endCondLst" == name)
        return (OpenXmlElement) new EndConditionList();
      if (24 == (int) namespaceId && "endSync" == name)
        return (OpenXmlElement) new EndSync();
      if (24 == (int) namespaceId && "iterate" == name)
        return (OpenXmlElement) new Iterate();
      if (24 == (int) namespaceId && "childTnLst" == name)
        return (OpenXmlElement) new ChildTimeNodeList();
      if (24 == (int) namespaceId && "subTnLst" == name)
        return (OpenXmlElement) new SubTimeNodeList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonTimeNode.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonTimeNode.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StartConditionList StartConditionList
    {
      get
      {
        return this.GetElement<StartConditionList>(0);
      }
      set
      {
        this.SetElement<StartConditionList>(0, value);
      }
    }

    public EndConditionList EndConditionList
    {
      get
      {
        return this.GetElement<EndConditionList>(1);
      }
      set
      {
        this.SetElement<EndConditionList>(1, value);
      }
    }

    public EndSync EndSync
    {
      get
      {
        return this.GetElement<EndSync>(2);
      }
      set
      {
        this.SetElement<EndSync>(2, value);
      }
    }

    public Iterate Iterate
    {
      get
      {
        return this.GetElement<Iterate>(3);
      }
      set
      {
        this.SetElement<Iterate>(3, value);
      }
    }

    public ChildTimeNodeList ChildTimeNodeList
    {
      get
      {
        return this.GetElement<ChildTimeNodeList>(4);
      }
      set
      {
        this.SetElement<ChildTimeNodeList>(4, value);
      }
    }

    public SubTimeNodeList SubTimeNodeList
    {
      get
      {
        return this.GetElement<SubTimeNodeList>(5);
      }
      set
      {
        this.SetElement<SubTimeNodeList>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "presetID" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "presetClass" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodePresetClassValues>();
      if ((int) namespaceId == 0 && "presetSubtype" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "dur" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "repeatCount" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "repeatDur" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "spd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "accel" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "decel" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "autoRev" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "restart" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodeRestartValues>();
      if ((int) namespaceId == 0 && "fill" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodeFillValues>();
      if ((int) namespaceId == 0 && "syncBehavior" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodeSyncValues>();
      if ((int) namespaceId == 0 && "tmFilter" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "evtFilter" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "display" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "masterRel" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodeMasterRelationValues>();
      if ((int) namespaceId == 0 && "bldLvl" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "grpId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "afterEffect" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "nodeType" == name)
        return (OpenXmlSimpleType) new EnumValue<TimeNodeValues>();
      if ((int) namespaceId == 0 && "nodePh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (49 == (int) namespaceId && "presetBounceEnd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonTimeNode>(deep);
    }
  }
}
