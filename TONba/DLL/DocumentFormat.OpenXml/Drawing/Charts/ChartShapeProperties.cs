// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (PresetGeometry))]
  [ChildElementInfo(typeof (CustomGeometry))]
  [ChildElementInfo(typeof (Transform2D))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (EffectList))]
  [ChildElementInfo(typeof (EffectDag))]
  [ChildElementInfo(typeof (Scene3DType))]
  [ChildElementInfo(typeof (Shape3DType))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class ChartShapeProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "bwMode"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[14]
    {
      "xfrm",
      "custGeom",
      "prstGeom",
      "noFill",
      "solidFill",
      "gradFill",
      "blipFill",
      "pattFill",
      "ln",
      "effectLst",
      "effectDag",
      "scene3d",
      "sp3d",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[14]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "spPr";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10349;

    public override string LocalName
    {
      get
      {
        return "spPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10349;
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
        return ChartShapeProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ChartShapeProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "bwMode")]
    public EnumValue<BlackWhiteModeValues> BlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public ChartShapeProperties()
    {
    }

    public ChartShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChartShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChartShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new Transform2D();
      if (10 == (int) namespaceId && "custGeom" == name)
        return (OpenXmlElement) new CustomGeometry();
      if (10 == (int) namespaceId && "prstGeom" == name)
        return (OpenXmlElement) new PresetGeometry();
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "ln" == name)
        return (OpenXmlElement) new Outline();
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      if (10 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3DType();
      if (10 == (int) namespaceId && "sp3d" == name)
        return (OpenXmlElement) new Shape3DType();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ChartShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ChartShapeProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Transform2D Transform2D
    {
      get
      {
        return this.GetElement<Transform2D>(0);
      }
      set
      {
        this.SetElement<Transform2D>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "bwMode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ChartShapeProperties>(deep);
    }
  }
}
