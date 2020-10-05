// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.LightRig
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SphereCoordinates), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class LightRig : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "rig",
      "dir"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "rot"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private const string tagName = "lightRig";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12948;

    public override string LocalName
    {
      get
      {
        return "lightRig";
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
        return 12948;
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
        return LightRig.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LightRig.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "rig")]
    public EnumValue<LightRigTypeValues> LightRigType
    {
      get
      {
        return (EnumValue<LightRigTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "dir")]
    public EnumValue<LightRigDirectionValues> LightDirectionType
    {
      get
      {
        return (EnumValue<LightRigDirectionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public LightRig()
    {
    }

    public LightRig(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LightRig(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LightRig(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "rot" == name)
        return (OpenXmlElement) new SphereCoordinates();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LightRig.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LightRig.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SphereCoordinates SphereCoordinates
    {
      get
      {
        return this.GetElement<SphereCoordinates>(0);
      }
      set
      {
        this.SetElement<SphereCoordinates>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "rig" == name)
        return (OpenXmlSimpleType) new EnumValue<LightRigTypeValues>();
      if (52 == (int) namespaceId && "dir" == name)
        return (OpenXmlSimpleType) new EnumValue<LightRigDirectionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LightRig>(deep);
    }
  }
}
