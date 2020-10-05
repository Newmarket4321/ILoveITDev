// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Ink.ContextNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Ink
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DestinationLink))]
  [ChildElementInfo(typeof (ContextNodeProperty))]
  [ChildElementInfo(typeof (SourceLink))]
  public class ContextNode : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[21]
    {
      "id",
      "type",
      "rotatedBoundingBox",
      "alignmentLevel",
      "contentType",
      "ascender",
      "descender",
      "baseline",
      "midline",
      "customRecognizerId",
      "mathML",
      "mathStruct",
      "mathSymbol",
      "beginModifierType",
      "endModifierType",
      "rotationAngle",
      "hotPoints",
      "centroid",
      "semanticType",
      "shapeName",
      "shapeGeometry"
    };
    private static byte[] attributeNamespaceIds = new byte[21];
    private const string tagName = "context";
    private const byte tagNsId = 45;
    internal const int ElementTypeIdConst = 12758;

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
        return 45;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12758;
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
        return ContextNode.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContextNode.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
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

    [SchemaAttr(0, "type")]
    public StringValue Type
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

    [SchemaAttr(0, "rotatedBoundingBox")]
    public ListValue<StringValue> RotatedBoundingBox
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "alignmentLevel")]
    public Int32Value AlignmentLevel
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

    [SchemaAttr(0, "contentType")]
    public Int32Value ContentType
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

    [SchemaAttr(0, "ascender")]
    public StringValue Ascender
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

    [SchemaAttr(0, "descender")]
    public StringValue Descender
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

    [SchemaAttr(0, "baseline")]
    public StringValue Baseline
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

    [SchemaAttr(0, "midline")]
    public StringValue Midline
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

    [SchemaAttr(0, "customRecognizerId")]
    public StringValue CustomRecognizerId
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

    [SchemaAttr(0, "mathML")]
    public StringValue MathML
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

    [SchemaAttr(0, "mathStruct")]
    public StringValue MathStruct
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "mathSymbol")]
    public StringValue MathSymbol
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

    [SchemaAttr(0, "beginModifierType")]
    public StringValue BeginModifierType
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endModifierType")]
    public StringValue EndModifierType
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

    [SchemaAttr(0, "rotationAngle")]
    public Int32Value RotationAngle
    {
      get
      {
        return (Int32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hotPoints")]
    public ListValue<StringValue> HotPoints
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "centroid")]
    public StringValue Centroid
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "semanticType")]
    public StringValue SemanticType
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shapeName")]
    public StringValue ShapeName
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shapeGeometry")]
    public ListValue<StringValue> ShapeGeometry
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    public ContextNode()
    {
    }

    public ContextNode(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ContextNode(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ContextNode(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (45 == (int) namespaceId && "property" == name)
        return (OpenXmlElement) new ContextNodeProperty();
      if (45 == (int) namespaceId && "sourceLink" == name)
        return (OpenXmlElement) new SourceLink();
      if (45 == (int) namespaceId && "destinationLink" == name)
        return (OpenXmlElement) new DestinationLink();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rotatedBoundingBox" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      if ((int) namespaceId == 0 && "alignmentLevel" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "contentType" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "ascender" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "descender" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "baseline" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "midline" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "customRecognizerId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "mathML" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "mathStruct" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "mathSymbol" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "beginModifierType" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "endModifierType" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rotationAngle" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "hotPoints" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      if ((int) namespaceId == 0 && "centroid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "semanticType" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "shapeName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "shapeGeometry" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContextNode>(deep);
    }
  }
}
