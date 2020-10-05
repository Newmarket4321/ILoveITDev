// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (Style))]
  [ChildElementInfo(typeof (PresentationLayoutVariables))]
  [GeneratedCode("DomGen", "2.0")]
  public class PropertySet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[28]
    {
      "presAssocID",
      "presName",
      "presStyleLbl",
      "presStyleIdx",
      "presStyleCnt",
      "loTypeId",
      "loCatId",
      "qsTypeId",
      "qsCatId",
      "csTypeId",
      "csCatId",
      "coherent3DOff",
      "phldrT",
      "phldr",
      "custAng",
      "custFlipVert",
      "custFlipHor",
      "custSzX",
      "custSzY",
      "custScaleX",
      "custScaleY",
      "custT",
      "custLinFactX",
      "custLinFactY",
      "custLinFactNeighborX",
      "custLinFactNeighborY",
      "custRadScaleRad",
      "custRadScaleInc"
    };
    private static byte[] attributeNamespaceIds = new byte[28];
    private static readonly string[] eleTagNames = new string[2]
    {
      "presLayoutVars",
      "style"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "prSet";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10755;

    public override string LocalName
    {
      get
      {
        return "prSet";
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
        return 10755;
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
        return PropertySet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PropertySet.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "presAssocID")]
    public StringValue PresentationElementId
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

    [SchemaAttr(0, "presName")]
    public StringValue PresentationName
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

    [SchemaAttr(0, "presStyleLbl")]
    public StringValue PresentationStyleLabel
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

    [SchemaAttr(0, "presStyleIdx")]
    public Int32Value PresentationStyleIndex
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

    [SchemaAttr(0, "presStyleCnt")]
    public Int32Value PresentationStyleCount
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "loTypeId")]
    public StringValue LayoutTypeId
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

    [SchemaAttr(0, "loCatId")]
    public StringValue LayoutCategoryId
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

    [SchemaAttr(0, "qsTypeId")]
    public StringValue QuickStyleTypeId
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

    [SchemaAttr(0, "qsCatId")]
    public StringValue QuickStyleCategoryId
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "csTypeId")]
    public StringValue ColorType
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "csCatId")]
    public StringValue ColorCategoryId
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "coherent3DOff")]
    public BooleanValue Coherent3D
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "phldrT")]
    public StringValue PlaceholderText
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "phldr")]
    public BooleanValue Placeholder
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custAng")]
    public Int32Value Rotation
    {
      get
      {
        return (Int32Value) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custFlipVert")]
    public BooleanValue VerticalFlip
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custFlipHor")]
    public BooleanValue HorizontalFlip
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

    [SchemaAttr(0, "custSzX")]
    public Int32Value FixedWidthOverride
    {
      get
      {
        return (Int32Value) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custSzY")]
    public Int32Value FixedHeightOverride
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

    [SchemaAttr(0, "custScaleX")]
    public Int32Value WidthScale
    {
      get
      {
        return (Int32Value) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custScaleY")]
    public Int32Value HightScale
    {
      get
      {
        return (Int32Value) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custT")]
    public BooleanValue TextChanged
    {
      get
      {
        return (BooleanValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custLinFactX")]
    public Int32Value FactorWidth
    {
      get
      {
        return (Int32Value) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custLinFactY")]
    public Int32Value FactorHeight
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

    [SchemaAttr(0, "custLinFactNeighborX")]
    public Int32Value NeighborOffsetWidth
    {
      get
      {
        return (Int32Value) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custLinFactNeighborY")]
    public Int32Value NeighborOffsetHeight
    {
      get
      {
        return (Int32Value) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custRadScaleRad")]
    public Int32Value RadiusScale
    {
      get
      {
        return (Int32Value) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "custRadScaleInc")]
    public Int32Value IncludeAngleScale
    {
      get
      {
        return (Int32Value) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    public PropertySet()
    {
    }

    public PropertySet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PropertySet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PropertySet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "presLayoutVars" == name)
        return (OpenXmlElement) new PresentationLayoutVariables();
      if (14 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new Style();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PropertySet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PropertySet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PresentationLayoutVariables PresentationLayoutVariables
    {
      get
      {
        return this.GetElement<PresentationLayoutVariables>(0);
      }
      set
      {
        this.SetElement<PresentationLayoutVariables>(0, value);
      }
    }

    public Style Style
    {
      get
      {
        return this.GetElement<Style>(1);
      }
      set
      {
        this.SetElement<Style>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "presAssocID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "presName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "presStyleLbl" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "presStyleIdx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "presStyleCnt" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "loTypeId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "loCatId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "qsTypeId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "qsCatId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "csTypeId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "csCatId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "coherent3DOff" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "phldrT" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "phldr" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "custAng" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custFlipVert" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "custFlipHor" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "custSzX" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custSzY" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custScaleX" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custScaleY" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custT" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "custLinFactX" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custLinFactY" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custLinFactNeighborX" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custLinFactNeighborY" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custRadScaleRad" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "custRadScaleInc" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PropertySet>(deep);
    }
  }
}
