// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Shape3DType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ExtrusionColor))]
  [ChildElementInfo(typeof (BevelTop))]
  [ChildElementInfo(typeof (BevelBottom))]
  [ChildElementInfo(typeof (ContourColor))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Shape3DType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "z",
      "extrusionH",
      "contourW",
      "prstMaterial"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[5]
    {
      "bevelT",
      "bevelB",
      "extrusionClr",
      "contourClr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "sp3d";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10041;

    public override string LocalName
    {
      get
      {
        return "sp3d";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10041;
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
        return Shape3DType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shape3DType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "z")]
    public Int64Value Z
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "extrusionH")]
    public Int64Value ExtrusionHeight
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "contourW")]
    public Int64Value ContourWidth
    {
      get
      {
        return (Int64Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "prstMaterial")]
    public EnumValue<PresetMaterialTypeValues> PresetMaterial
    {
      get
      {
        return (EnumValue<PresetMaterialTypeValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Shape3DType()
    {
    }

    public Shape3DType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Shape3DType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Shape3DType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "bevelT" == name)
        return (OpenXmlElement) new BevelTop();
      if (10 == (int) namespaceId && "bevelB" == name)
        return (OpenXmlElement) new BevelBottom();
      if (10 == (int) namespaceId && "extrusionClr" == name)
        return (OpenXmlElement) new ExtrusionColor();
      if (10 == (int) namespaceId && "contourClr" == name)
        return (OpenXmlElement) new ContourColor();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Shape3DType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Shape3DType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BevelTop BevelTop
    {
      get
      {
        return this.GetElement<BevelTop>(0);
      }
      set
      {
        this.SetElement<BevelTop>(0, value);
      }
    }

    public BevelBottom BevelBottom
    {
      get
      {
        return this.GetElement<BevelBottom>(1);
      }
      set
      {
        this.SetElement<BevelBottom>(1, value);
      }
    }

    public ExtrusionColor ExtrusionColor
    {
      get
      {
        return this.GetElement<ExtrusionColor>(2);
      }
      set
      {
        this.SetElement<ExtrusionColor>(2, value);
      }
    }

    public ContourColor ContourColor
    {
      get
      {
        return this.GetElement<ContourColor>(3);
      }
      set
      {
        this.SetElement<ContourColor>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "z" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "extrusionH" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "contourW" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "prstMaterial" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetMaterialTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shape3DType>(deep);
    }
  }
}
