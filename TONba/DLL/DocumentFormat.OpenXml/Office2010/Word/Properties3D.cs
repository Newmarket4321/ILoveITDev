// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Properties3D
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (BevelBottom), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BevelTop), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ContourColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ExtrusionColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Properties3D : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "extrusionH",
      "contourW",
      "prstMaterial"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "bevelT",
      "bevelB",
      "extrusionClr",
      "contourClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "props3d";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12926;

    public override string LocalName
    {
      get
      {
        return "props3d";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12926;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Properties3D.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Properties3D.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "extrusionH")]
    public Int64Value ExtrusionHeight
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

    [SchemaAttr(52, "contourW")]
    public Int64Value ContourWidth
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

    [SchemaAttr(52, "prstMaterial")]
    public EnumValue<PresetMaterialTypeValues> PresetMaterialType
    {
      get
      {
        return (EnumValue<PresetMaterialTypeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Properties3D()
    {
    }

    public Properties3D(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Properties3D(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Properties3D(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "bevelT" == name)
        return (OpenXmlElement) new BevelTop();
      if (52 == (int) namespaceId && "bevelB" == name)
        return (OpenXmlElement) new BevelBottom();
      if (52 == (int) namespaceId && "extrusionClr" == name)
        return (OpenXmlElement) new ExtrusionColor();
      if (52 == (int) namespaceId && "contourClr" == name)
        return (OpenXmlElement) new ContourColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Properties3D.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Properties3D.eleNamespaceIds;
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "extrusionH" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "contourW" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "prstMaterial" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetMaterialTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Properties3D>(deep);
    }
  }
}
