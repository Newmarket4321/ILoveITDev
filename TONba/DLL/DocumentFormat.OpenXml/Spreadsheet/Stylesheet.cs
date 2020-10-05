// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Stylesheet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Fonts))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CellFormats))]
  [ChildElementInfo(typeof (StylesheetExtensionList))]
  [ChildElementInfo(typeof (Fills))]
  [ChildElementInfo(typeof (Borders))]
  [ChildElementInfo(typeof (CellStyleFormats))]
  [ChildElementInfo(typeof (NumberingFormats))]
  [ChildElementInfo(typeof (CellStyles))]
  [ChildElementInfo(typeof (DifferentialFormats))]
  [ChildElementInfo(typeof (TableStyles))]
  [ChildElementInfo(typeof (Colors))]
  public class Stylesheet : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[11]
    {
      "numFmts",
      "fonts",
      "fills",
      "borders",
      "cellStyleXfs",
      "cellXfs",
      "cellStyles",
      "dxfs",
      "tableStyles",
      "colors",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "styleSheet";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11110;

    public override string LocalName
    {
      get
      {
        return "styleSheet";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11110;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Stylesheet(WorkbookStylesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorkbookStylesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorkbookStylesPart WorkbookStylesPart
    {
      get
      {
        return this.OpenXmlPart as WorkbookStylesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Stylesheet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Stylesheet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Stylesheet(string outerXml)
      : base(outerXml)
    {
    }

    public Stylesheet()
    {
    }

    public void Save(WorkbookStylesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "numFmts" == name)
        return (OpenXmlElement) new NumberingFormats();
      if (22 == (int) namespaceId && "fonts" == name)
        return (OpenXmlElement) new Fonts();
      if (22 == (int) namespaceId && "fills" == name)
        return (OpenXmlElement) new Fills();
      if (22 == (int) namespaceId && "borders" == name)
        return (OpenXmlElement) new Borders();
      if (22 == (int) namespaceId && "cellStyleXfs" == name)
        return (OpenXmlElement) new CellStyleFormats();
      if (22 == (int) namespaceId && "cellXfs" == name)
        return (OpenXmlElement) new CellFormats();
      if (22 == (int) namespaceId && "cellStyles" == name)
        return (OpenXmlElement) new CellStyles();
      if (22 == (int) namespaceId && "dxfs" == name)
        return (OpenXmlElement) new DifferentialFormats();
      if (22 == (int) namespaceId && "tableStyles" == name)
        return (OpenXmlElement) new TableStyles();
      if (22 == (int) namespaceId && "colors" == name)
        return (OpenXmlElement) new Colors();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new StylesheetExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Stylesheet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Stylesheet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NumberingFormats NumberingFormats
    {
      get
      {
        return this.GetElement<NumberingFormats>(0);
      }
      set
      {
        this.SetElement<NumberingFormats>(0, value);
      }
    }

    public Fonts Fonts
    {
      get
      {
        return this.GetElement<Fonts>(1);
      }
      set
      {
        this.SetElement<Fonts>(1, value);
      }
    }

    public Fills Fills
    {
      get
      {
        return this.GetElement<Fills>(2);
      }
      set
      {
        this.SetElement<Fills>(2, value);
      }
    }

    public Borders Borders
    {
      get
      {
        return this.GetElement<Borders>(3);
      }
      set
      {
        this.SetElement<Borders>(3, value);
      }
    }

    public CellStyleFormats CellStyleFormats
    {
      get
      {
        return this.GetElement<CellStyleFormats>(4);
      }
      set
      {
        this.SetElement<CellStyleFormats>(4, value);
      }
    }

    public CellFormats CellFormats
    {
      get
      {
        return this.GetElement<CellFormats>(5);
      }
      set
      {
        this.SetElement<CellFormats>(5, value);
      }
    }

    public CellStyles CellStyles
    {
      get
      {
        return this.GetElement<CellStyles>(6);
      }
      set
      {
        this.SetElement<CellStyles>(6, value);
      }
    }

    public DifferentialFormats DifferentialFormats
    {
      get
      {
        return this.GetElement<DifferentialFormats>(7);
      }
      set
      {
        this.SetElement<DifferentialFormats>(7, value);
      }
    }

    public TableStyles TableStyles
    {
      get
      {
        return this.GetElement<TableStyles>(8);
      }
      set
      {
        this.SetElement<TableStyles>(8, value);
      }
    }

    public Colors Colors
    {
      get
      {
        return this.GetElement<Colors>(9);
      }
      set
      {
        this.SetElement<Colors>(9, value);
      }
    }

    public StylesheetExtensionList StylesheetExtensionList
    {
      get
      {
        return this.GetElement<StylesheetExtensionList>(10);
      }
      set
      {
        this.SetElement<StylesheetExtensionList>(10, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Stylesheet>(deep);
    }
  }
}
