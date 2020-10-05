// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ColorScheme
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Accent2Color))]
  [ChildElementInfo(typeof (FollowedHyperlinkColor))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Hyperlink))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Light2Color))]
  [ChildElementInfo(typeof (Dark1Color))]
  [ChildElementInfo(typeof (Light1Color))]
  [ChildElementInfo(typeof (Dark2Color))]
  [ChildElementInfo(typeof (Accent3Color))]
  [ChildElementInfo(typeof (Accent1Color))]
  [ChildElementInfo(typeof (Accent4Color))]
  [ChildElementInfo(typeof (Accent5Color))]
  [ChildElementInfo(typeof (Accent6Color))]
  public class ColorScheme : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[13]
    {
      "dk1",
      "lt1",
      "dk2",
      "lt2",
      "accent1",
      "accent2",
      "accent3",
      "accent4",
      "accent5",
      "accent6",
      "hlink",
      "folHlink",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[13]
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
      (byte) 10
    };
    private const string tagName = "clrScheme";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10144;

    public override string LocalName
    {
      get
      {
        return "clrScheme";
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
        return 10144;
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
        return ColorScheme.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorScheme.attributeNamespaceIds;
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

    public ColorScheme()
    {
    }

    public ColorScheme(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorScheme(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorScheme(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "dk1" == name)
        return (OpenXmlElement) new Dark1Color();
      if (10 == (int) namespaceId && "lt1" == name)
        return (OpenXmlElement) new Light1Color();
      if (10 == (int) namespaceId && "dk2" == name)
        return (OpenXmlElement) new Dark2Color();
      if (10 == (int) namespaceId && "lt2" == name)
        return (OpenXmlElement) new Light2Color();
      if (10 == (int) namespaceId && "accent1" == name)
        return (OpenXmlElement) new Accent1Color();
      if (10 == (int) namespaceId && "accent2" == name)
        return (OpenXmlElement) new Accent2Color();
      if (10 == (int) namespaceId && "accent3" == name)
        return (OpenXmlElement) new Accent3Color();
      if (10 == (int) namespaceId && "accent4" == name)
        return (OpenXmlElement) new Accent4Color();
      if (10 == (int) namespaceId && "accent5" == name)
        return (OpenXmlElement) new Accent5Color();
      if (10 == (int) namespaceId && "accent6" == name)
        return (OpenXmlElement) new Accent6Color();
      if (10 == (int) namespaceId && "hlink" == name)
        return (OpenXmlElement) new Hyperlink();
      if (10 == (int) namespaceId && "folHlink" == name)
        return (OpenXmlElement) new FollowedHyperlinkColor();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ColorScheme.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ColorScheme.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Dark1Color Dark1Color
    {
      get
      {
        return this.GetElement<Dark1Color>(0);
      }
      set
      {
        this.SetElement<Dark1Color>(0, value);
      }
    }

    public Light1Color Light1Color
    {
      get
      {
        return this.GetElement<Light1Color>(1);
      }
      set
      {
        this.SetElement<Light1Color>(1, value);
      }
    }

    public Dark2Color Dark2Color
    {
      get
      {
        return this.GetElement<Dark2Color>(2);
      }
      set
      {
        this.SetElement<Dark2Color>(2, value);
      }
    }

    public Light2Color Light2Color
    {
      get
      {
        return this.GetElement<Light2Color>(3);
      }
      set
      {
        this.SetElement<Light2Color>(3, value);
      }
    }

    public Accent1Color Accent1Color
    {
      get
      {
        return this.GetElement<Accent1Color>(4);
      }
      set
      {
        this.SetElement<Accent1Color>(4, value);
      }
    }

    public Accent2Color Accent2Color
    {
      get
      {
        return this.GetElement<Accent2Color>(5);
      }
      set
      {
        this.SetElement<Accent2Color>(5, value);
      }
    }

    public Accent3Color Accent3Color
    {
      get
      {
        return this.GetElement<Accent3Color>(6);
      }
      set
      {
        this.SetElement<Accent3Color>(6, value);
      }
    }

    public Accent4Color Accent4Color
    {
      get
      {
        return this.GetElement<Accent4Color>(7);
      }
      set
      {
        this.SetElement<Accent4Color>(7, value);
      }
    }

    public Accent5Color Accent5Color
    {
      get
      {
        return this.GetElement<Accent5Color>(8);
      }
      set
      {
        this.SetElement<Accent5Color>(8, value);
      }
    }

    public Accent6Color Accent6Color
    {
      get
      {
        return this.GetElement<Accent6Color>(9);
      }
      set
      {
        this.SetElement<Accent6Color>(9, value);
      }
    }

    public Hyperlink Hyperlink
    {
      get
      {
        return this.GetElement<Hyperlink>(10);
      }
      set
      {
        this.SetElement<Hyperlink>(10, value);
      }
    }

    public FollowedHyperlinkColor FollowedHyperlinkColor
    {
      get
      {
        return this.GetElement<FollowedHyperlinkColor>(11);
      }
      set
      {
        this.SetElement<FollowedHyperlinkColor>(11, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(12);
      }
      set
      {
        this.SetElement<ExtensionList>(12, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorScheme>(deep);
    }
  }
}
