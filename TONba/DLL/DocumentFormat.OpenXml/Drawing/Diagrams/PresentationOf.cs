// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  public class PresentationOf : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "axis",
      "ptType",
      "hideLastTrans",
      "st",
      "cnt",
      "step"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 14
    };
    private const string tagName = "presOf";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10714;

    public override string LocalName
    {
      get
      {
        return "presOf";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10714;
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
        return PresentationOf.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PresentationOf.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "axis")]
    public ListValue<EnumValue<AxisValues>> Axis
    {
      get
      {
        return (ListValue<EnumValue<AxisValues>>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ptType")]
    public ListValue<EnumValue<ElementValues>> PointType
    {
      get
      {
        return (ListValue<EnumValue<ElementValues>>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hideLastTrans")]
    public ListValue<BooleanValue> HideLastTrans
    {
      get
      {
        return (ListValue<BooleanValue>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "st")]
    public ListValue<Int32Value> Start
    {
      get
      {
        return (ListValue<Int32Value>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cnt")]
    public ListValue<UInt32Value> Count
    {
      get
      {
        return (ListValue<UInt32Value>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "step")]
    public ListValue<Int32Value> Step
    {
      get
      {
        return (ListValue<Int32Value>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public PresentationOf()
    {
    }

    public PresentationOf(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PresentationOf(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PresentationOf(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PresentationOf.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PresentationOf.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "axis" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<AxisValues>>();
      if ((int) namespaceId == 0 && "ptType" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<ElementValues>>();
      if ((int) namespaceId == 0 && "hideLastTrans" == name)
        return (OpenXmlSimpleType) new ListValue<BooleanValue>();
      if ((int) namespaceId == 0 && "st" == name)
        return (OpenXmlSimpleType) new ListValue<Int32Value>();
      if ((int) namespaceId == 0 && "cnt" == name)
        return (OpenXmlSimpleType) new ListValue<UInt32Value>();
      if ((int) namespaceId == 0 && "step" == name)
        return (OpenXmlSimpleType) new ListValue<Int32Value>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresentationOf>(deep);
    }
  }
}
