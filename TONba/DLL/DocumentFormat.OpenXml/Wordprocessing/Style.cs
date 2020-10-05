// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Style
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (PrimaryStyle))]
  [ChildElementInfo(typeof (PersonalCompose))]
  [ChildElementInfo(typeof (PersonalReply))]
  [ChildElementInfo(typeof (TableStyleConditionalFormattingTableRowProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StyleName))]
  [ChildElementInfo(typeof (Aliases))]
  [ChildElementInfo(typeof (BasedOn))]
  [ChildElementInfo(typeof (NextParagraphStyle))]
  [ChildElementInfo(typeof (LinkedStyle))]
  [ChildElementInfo(typeof (AutoRedefine))]
  [ChildElementInfo(typeof (StyleHidden))]
  [ChildElementInfo(typeof (UIPriority))]
  [ChildElementInfo(typeof (SemiHidden))]
  [ChildElementInfo(typeof (UnhideWhenUsed))]
  [ChildElementInfo(typeof (Locked))]
  [ChildElementInfo(typeof (Personal))]
  [ChildElementInfo(typeof (Rsid))]
  [ChildElementInfo(typeof (StyleParagraphProperties))]
  [ChildElementInfo(typeof (StyleRunProperties))]
  [ChildElementInfo(typeof (StyleTableProperties))]
  [ChildElementInfo(typeof (StyleTableCellProperties))]
  [ChildElementInfo(typeof (TableStyleProperties))]
  public class Style : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "type",
      "styleId",
      "default",
      "customStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[22]
    {
      "name",
      "aliases",
      "basedOn",
      "next",
      "link",
      "autoRedefine",
      "hidden",
      "uiPriority",
      "semiHidden",
      "unhideWhenUsed",
      "qFormat",
      "locked",
      "personal",
      "personalCompose",
      "personalReply",
      "rsid",
      "pPr",
      "rPr",
      "tblPr",
      "trPr",
      "tcPr",
      "tblStylePr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[22]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "style";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11962;

    public override string LocalName
    {
      get
      {
        return "style";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11962;
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
        return Style.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Style.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "type")]
    public EnumValue<StyleValues> Type
    {
      get
      {
        return (EnumValue<StyleValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "styleId")]
    public StringValue StyleId
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

    [SchemaAttr(23, "default")]
    public OnOffValue Default
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "customStyle")]
    public OnOffValue CustomStyle
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Style()
    {
    }

    public Style(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Style(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Style(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new StyleName();
      if (23 == (int) namespaceId && "aliases" == name)
        return (OpenXmlElement) new Aliases();
      if (23 == (int) namespaceId && "basedOn" == name)
        return (OpenXmlElement) new BasedOn();
      if (23 == (int) namespaceId && "next" == name)
        return (OpenXmlElement) new NextParagraphStyle();
      if (23 == (int) namespaceId && "link" == name)
        return (OpenXmlElement) new LinkedStyle();
      if (23 == (int) namespaceId && "autoRedefine" == name)
        return (OpenXmlElement) new AutoRedefine();
      if (23 == (int) namespaceId && "hidden" == name)
        return (OpenXmlElement) new StyleHidden();
      if (23 == (int) namespaceId && "uiPriority" == name)
        return (OpenXmlElement) new UIPriority();
      if (23 == (int) namespaceId && "semiHidden" == name)
        return (OpenXmlElement) new SemiHidden();
      if (23 == (int) namespaceId && "unhideWhenUsed" == name)
        return (OpenXmlElement) new UnhideWhenUsed();
      if (23 == (int) namespaceId && "qFormat" == name)
        return (OpenXmlElement) new PrimaryStyle();
      if (23 == (int) namespaceId && "locked" == name)
        return (OpenXmlElement) new Locked();
      if (23 == (int) namespaceId && "personal" == name)
        return (OpenXmlElement) new Personal();
      if (23 == (int) namespaceId && "personalCompose" == name)
        return (OpenXmlElement) new PersonalCompose();
      if (23 == (int) namespaceId && "personalReply" == name)
        return (OpenXmlElement) new PersonalReply();
      if (23 == (int) namespaceId && "rsid" == name)
        return (OpenXmlElement) new Rsid();
      if (23 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new StyleParagraphProperties();
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new StyleRunProperties();
      if (23 == (int) namespaceId && "tblPr" == name)
        return (OpenXmlElement) new StyleTableProperties();
      if (23 == (int) namespaceId && "trPr" == name)
        return (OpenXmlElement) new TableStyleConditionalFormattingTableRowProperties();
      if (23 == (int) namespaceId && "tcPr" == name)
        return (OpenXmlElement) new StyleTableCellProperties();
      if (23 == (int) namespaceId && "tblStylePr" == name)
        return (OpenXmlElement) new TableStyleProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Style.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Style.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StyleName StyleName
    {
      get
      {
        return this.GetElement<StyleName>(0);
      }
      set
      {
        this.SetElement<StyleName>(0, value);
      }
    }

    public Aliases Aliases
    {
      get
      {
        return this.GetElement<Aliases>(1);
      }
      set
      {
        this.SetElement<Aliases>(1, value);
      }
    }

    public BasedOn BasedOn
    {
      get
      {
        return this.GetElement<BasedOn>(2);
      }
      set
      {
        this.SetElement<BasedOn>(2, value);
      }
    }

    public NextParagraphStyle NextParagraphStyle
    {
      get
      {
        return this.GetElement<NextParagraphStyle>(3);
      }
      set
      {
        this.SetElement<NextParagraphStyle>(3, value);
      }
    }

    public LinkedStyle LinkedStyle
    {
      get
      {
        return this.GetElement<LinkedStyle>(4);
      }
      set
      {
        this.SetElement<LinkedStyle>(4, value);
      }
    }

    public AutoRedefine AutoRedefine
    {
      get
      {
        return this.GetElement<AutoRedefine>(5);
      }
      set
      {
        this.SetElement<AutoRedefine>(5, value);
      }
    }

    public StyleHidden StyleHidden
    {
      get
      {
        return this.GetElement<StyleHidden>(6);
      }
      set
      {
        this.SetElement<StyleHidden>(6, value);
      }
    }

    public UIPriority UIPriority
    {
      get
      {
        return this.GetElement<UIPriority>(7);
      }
      set
      {
        this.SetElement<UIPriority>(7, value);
      }
    }

    public SemiHidden SemiHidden
    {
      get
      {
        return this.GetElement<SemiHidden>(8);
      }
      set
      {
        this.SetElement<SemiHidden>(8, value);
      }
    }

    public UnhideWhenUsed UnhideWhenUsed
    {
      get
      {
        return this.GetElement<UnhideWhenUsed>(9);
      }
      set
      {
        this.SetElement<UnhideWhenUsed>(9, value);
      }
    }

    public PrimaryStyle PrimaryStyle
    {
      get
      {
        return this.GetElement<PrimaryStyle>(10);
      }
      set
      {
        this.SetElement<PrimaryStyle>(10, value);
      }
    }

    public Locked Locked
    {
      get
      {
        return this.GetElement<Locked>(11);
      }
      set
      {
        this.SetElement<Locked>(11, value);
      }
    }

    public Personal Personal
    {
      get
      {
        return this.GetElement<Personal>(12);
      }
      set
      {
        this.SetElement<Personal>(12, value);
      }
    }

    public PersonalCompose PersonalCompose
    {
      get
      {
        return this.GetElement<PersonalCompose>(13);
      }
      set
      {
        this.SetElement<PersonalCompose>(13, value);
      }
    }

    public PersonalReply PersonalReply
    {
      get
      {
        return this.GetElement<PersonalReply>(14);
      }
      set
      {
        this.SetElement<PersonalReply>(14, value);
      }
    }

    public Rsid Rsid
    {
      get
      {
        return this.GetElement<Rsid>(15);
      }
      set
      {
        this.SetElement<Rsid>(15, value);
      }
    }

    public StyleParagraphProperties StyleParagraphProperties
    {
      get
      {
        return this.GetElement<StyleParagraphProperties>(16);
      }
      set
      {
        this.SetElement<StyleParagraphProperties>(16, value);
      }
    }

    public StyleRunProperties StyleRunProperties
    {
      get
      {
        return this.GetElement<StyleRunProperties>(17);
      }
      set
      {
        this.SetElement<StyleRunProperties>(17, value);
      }
    }

    public StyleTableProperties StyleTableProperties
    {
      get
      {
        return this.GetElement<StyleTableProperties>(18);
      }
      set
      {
        this.SetElement<StyleTableProperties>(18, value);
      }
    }

    public TableStyleConditionalFormattingTableRowProperties TableStyleConditionalFormattingTableRowProperties
    {
      get
      {
        return this.GetElement<TableStyleConditionalFormattingTableRowProperties>(19);
      }
      set
      {
        this.SetElement<TableStyleConditionalFormattingTableRowProperties>(19, value);
      }
    }

    public StyleTableCellProperties StyleTableCellProperties
    {
      get
      {
        return this.GetElement<StyleTableCellProperties>(20);
      }
      set
      {
        this.SetElement<StyleTableCellProperties>(20, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<StyleValues>();
      if (23 == (int) namespaceId && "styleId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "default" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "customStyle" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Style>(deep);
    }
  }
}
