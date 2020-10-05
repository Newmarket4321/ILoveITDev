// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Cell3DProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (LightRig))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Bevel))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class Cell3DProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "prstMaterial"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "bevel",
      "lightRig",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cell3D";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10253;

    public override string LocalName
    {
      get
      {
        return "cell3D";
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
        return 10253;
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
        return Cell3DProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Cell3DProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prstMaterial")]
    public EnumValue<PresetMaterialTypeValues> PresetMaterial
    {
      get
      {
        return (EnumValue<PresetMaterialTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Cell3DProperties()
    {
    }

    public Cell3DProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Cell3DProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Cell3DProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "bevel" == name)
        return (OpenXmlElement) new Bevel();
      if (10 == (int) namespaceId && "lightRig" == name)
        return (OpenXmlElement) new LightRig();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Cell3DProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Cell3DProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Bevel Bevel
    {
      get
      {
        return this.GetElement<Bevel>(0);
      }
      set
      {
        this.SetElement<Bevel>(0, value);
      }
    }

    public LightRig LightRig
    {
      get
      {
        return this.GetElement<LightRig>(1);
      }
      set
      {
        this.SetElement<LightRig>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prstMaterial" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetMaterialTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Cell3DProperties>(deep);
    }
  }
}
