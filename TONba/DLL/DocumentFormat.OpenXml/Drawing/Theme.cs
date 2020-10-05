// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Theme
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ObjectDefaults))]
  [ChildElementInfo(typeof (ThemeElements))]
  [ChildElementInfo(typeof (ExtraColorSchemeList))]
  [ChildElementInfo(typeof (CustomColorList))]
  [ChildElementInfo(typeof (OfficeStyleSheetExtensionList))]
  public class Theme : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "name",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 0,
      (byte) 73
    };
    private static readonly string[] eleTagNames = new string[5]
    {
      "themeElements",
      "objectDefaults",
      "extraClrSchemeLst",
      "custClrLst",
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
    private const string tagName = "theme";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10122;

    public override string LocalName
    {
      get
      {
        return "theme";
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
        return 10122;
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
        return Theme.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Theme.attributeNamespaceIds;
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

    [SchemaAttr(73, "id")]
    public StringValue ThemeId
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

    internal Theme(ThemePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ThemePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ThemePart ThemePart
    {
      get
      {
        return this.OpenXmlPart as ThemePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Theme(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Theme(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Theme(string outerXml)
      : base(outerXml)
    {
    }

    public Theme()
    {
    }

    public void Save(ThemePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "themeElements" == name)
        return (OpenXmlElement) new ThemeElements();
      if (10 == (int) namespaceId && "objectDefaults" == name)
        return (OpenXmlElement) new ObjectDefaults();
      if (10 == (int) namespaceId && "extraClrSchemeLst" == name)
        return (OpenXmlElement) new ExtraColorSchemeList();
      if (10 == (int) namespaceId && "custClrLst" == name)
        return (OpenXmlElement) new CustomColorList();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeStyleSheetExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Theme.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Theme.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ThemeElements ThemeElements
    {
      get
      {
        return this.GetElement<ThemeElements>(0);
      }
      set
      {
        this.SetElement<ThemeElements>(0, value);
      }
    }

    public ObjectDefaults ObjectDefaults
    {
      get
      {
        return this.GetElement<ObjectDefaults>(1);
      }
      set
      {
        this.SetElement<ObjectDefaults>(1, value);
      }
    }

    public ExtraColorSchemeList ExtraColorSchemeList
    {
      get
      {
        return this.GetElement<ExtraColorSchemeList>(2);
      }
      set
      {
        this.SetElement<ExtraColorSchemeList>(2, value);
      }
    }

    public CustomColorList CustomColorList
    {
      get
      {
        return this.GetElement<CustomColorList>(3);
      }
      set
      {
        this.SetElement<CustomColorList>(3, value);
      }
    }

    public OfficeStyleSheetExtensionList OfficeStyleSheetExtensionList
    {
      get
      {
        return this.GetElement<OfficeStyleSheetExtensionList>(4);
      }
      set
      {
        this.SetElement<OfficeStyleSheetExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (73 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Theme>(deep);
    }
  }
}
