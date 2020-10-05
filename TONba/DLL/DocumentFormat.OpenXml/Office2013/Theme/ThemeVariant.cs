// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Theme.ThemeVariant
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Theme
{
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class ThemeVariant : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "name",
      "vid",
      "cx",
      "cy",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 73
    };
    private const string tagName = "themeVariant";
    private const byte tagNsId = 73;
    internal const int ElementTypeIdConst = 13434;

    public override string LocalName
    {
      get
      {
        return "themeVariant";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 73;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13434;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ThemeVariant.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ThemeVariant.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "vid")]
    public StringValue Vid
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

    [SchemaAttr(0, "cx")]
    public Int64Value X
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

    [SchemaAttr(0, "cy")]
    public Int64Value Y
    {
      get
      {
        return (Int64Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public ThemeVariant()
    {
    }

    public ThemeVariant(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ThemeVariant(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ThemeVariant(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (73 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ThemeVariant.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ThemeVariant.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(0);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "vid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cx" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "cy" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ThemeVariant>(deep);
    }
  }
}
