// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (EffectList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TransformGroup))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (GroupFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (EffectDag))]
  [ChildElementInfo(typeof (Scene3DType))]
  public class VisualGroupShapeProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "bwMode"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[11]
    {
      "xfrm",
      "noFill",
      "solidFill",
      "gradFill",
      "blipFill",
      "pattFill",
      "grpFill",
      "effectLst",
      "effectDag",
      "scene3d",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
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
      (byte) 10
    };
    private const string tagName = "grpSpPr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10316;

    public override string LocalName
    {
      get
      {
        return "grpSpPr";
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
        return 10316;
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
        return VisualGroupShapeProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VisualGroupShapeProperties.attributeNamespaceIds;
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

    public VisualGroupShapeProperties()
    {
    }

    public VisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VisualGroupShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VisualGroupShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new TransformGroup();
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
      if (10 == (int) namespaceId && "grpFill" == name)
        return (OpenXmlElement) new GroupFill();
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      if (10 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3DType();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return VisualGroupShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return VisualGroupShapeProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TransformGroup TransformGroup
    {
      get
      {
        return this.GetElement<TransformGroup>(0);
      }
      set
      {
        this.SetElement<TransformGroup>(0, value);
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
      return (OpenXmlElement) this.CloneImp<VisualGroupShapeProperties>(deep);
    }
  }
}
