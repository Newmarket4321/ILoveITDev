// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ThemeOverride
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ColorScheme))]
  [ChildElementInfo(typeof (FormatScheme))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FontScheme))]
  public class ThemeOverride : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "clrScheme",
      "fontScheme",
      "fmtScheme"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "themeOverride";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10123;

    public override string LocalName
    {
      get
      {
        return "themeOverride";
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
        return 10123;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal ThemeOverride(ThemeOverridePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ThemeOverridePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ThemeOverridePart ThemeOverridePart
    {
      get
      {
        return this.OpenXmlPart as ThemeOverridePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ThemeOverride(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ThemeOverride(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ThemeOverride(string outerXml)
      : base(outerXml)
    {
    }

    public ThemeOverride()
    {
    }

    public void Save(ThemeOverridePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "clrScheme" == name)
        return (OpenXmlElement) new ColorScheme();
      if (10 == (int) namespaceId && "fontScheme" == name)
        return (OpenXmlElement) new FontScheme();
      if (10 == (int) namespaceId && "fmtScheme" == name)
        return (OpenXmlElement) new FormatScheme();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ThemeOverride.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ThemeOverride.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ColorScheme ColorScheme
    {
      get
      {
        return this.GetElement<ColorScheme>(0);
      }
      set
      {
        this.SetElement<ColorScheme>(0, value);
      }
    }

    public FontScheme FontScheme
    {
      get
      {
        return this.GetElement<FontScheme>(1);
      }
      set
      {
        this.SetElement<FontScheme>(1, value);
      }
    }

    public FormatScheme FormatScheme
    {
      get
      {
        return this.GetElement<FormatScheme>(2);
      }
      set
      {
        this.SetElement<FormatScheme>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ThemeOverride>(deep);
    }
  }
}
