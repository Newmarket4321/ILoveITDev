// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (NotesViewProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OutlineViewProperties))]
  [ChildElementInfo(typeof (NormalViewProperties))]
  [ChildElementInfo(typeof (SlideViewProperties))]
  [ChildElementInfo(typeof (SorterViewProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (NotesTextViewProperties))]
  [ChildElementInfo(typeof (GridSpacing))]
  public class ViewProperties : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "lastView",
      "showComments"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[8]
    {
      "normalViewPr",
      "slideViewPr",
      "outlineViewPr",
      "notesTextViewPr",
      "sorterViewPr",
      "notesViewPr",
      "gridSpacing",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "viewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12246;

    public override string LocalName
    {
      get
      {
        return "viewPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12246;
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
        return ViewProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ViewProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "lastView")]
    public EnumValue<ViewValues> LastView
    {
      get
      {
        return (EnumValue<ViewValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showComments")]
    public BooleanValue ShowComments
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal ViewProperties(ViewPropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ViewPropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ViewPropertiesPart ViewPropertiesPart
    {
      get
      {
        return this.OpenXmlPart as ViewPropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    public ViewProperties()
    {
    }

    public void Save(ViewPropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "normalViewPr" == name)
        return (OpenXmlElement) new NormalViewProperties();
      if (24 == (int) namespaceId && "slideViewPr" == name)
        return (OpenXmlElement) new SlideViewProperties();
      if (24 == (int) namespaceId && "outlineViewPr" == name)
        return (OpenXmlElement) new OutlineViewProperties();
      if (24 == (int) namespaceId && "notesTextViewPr" == name)
        return (OpenXmlElement) new NotesTextViewProperties();
      if (24 == (int) namespaceId && "sorterViewPr" == name)
        return (OpenXmlElement) new SorterViewProperties();
      if (24 == (int) namespaceId && "notesViewPr" == name)
        return (OpenXmlElement) new NotesViewProperties();
      if (24 == (int) namespaceId && "gridSpacing" == name)
        return (OpenXmlElement) new GridSpacing();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ViewProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NormalViewProperties NormalViewProperties
    {
      get
      {
        return this.GetElement<NormalViewProperties>(0);
      }
      set
      {
        this.SetElement<NormalViewProperties>(0, value);
      }
    }

    public SlideViewProperties SlideViewProperties
    {
      get
      {
        return this.GetElement<SlideViewProperties>(1);
      }
      set
      {
        this.SetElement<SlideViewProperties>(1, value);
      }
    }

    public OutlineViewProperties OutlineViewProperties
    {
      get
      {
        return this.GetElement<OutlineViewProperties>(2);
      }
      set
      {
        this.SetElement<OutlineViewProperties>(2, value);
      }
    }

    public NotesTextViewProperties NotesTextViewProperties
    {
      get
      {
        return this.GetElement<NotesTextViewProperties>(3);
      }
      set
      {
        this.SetElement<NotesTextViewProperties>(3, value);
      }
    }

    public SorterViewProperties SorterViewProperties
    {
      get
      {
        return this.GetElement<SorterViewProperties>(4);
      }
      set
      {
        this.SetElement<SorterViewProperties>(4, value);
      }
    }

    public NotesViewProperties NotesViewProperties
    {
      get
      {
        return this.GetElement<NotesViewProperties>(5);
      }
      set
      {
        this.SetElement<NotesViewProperties>(5, value);
      }
    }

    public GridSpacing GridSpacing
    {
      get
      {
        return this.GetElement<GridSpacing>(6);
      }
      set
      {
        this.SetElement<GridSpacing>(6, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(7);
      }
      set
      {
        this.SetElement<ExtensionList>(7, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "lastView" == name)
        return (OpenXmlSimpleType) new EnumValue<ViewValues>();
      if ((int) namespaceId == 0 && "showComments" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ViewProperties>(deep);
    }
  }
}
