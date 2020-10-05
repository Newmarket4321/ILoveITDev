// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Workbook
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.ExcelAc;
using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomWorkbookViews))]
  [ChildElementInfo(typeof (WorkbookExtensionList))]
  [ChildElementInfo(typeof (FileVersion))]
  [ChildElementInfo(typeof (FileSharing))]
  [ChildElementInfo(typeof (WorkbookProperties))]
  [ChildElementInfo(typeof (AbsolutePath), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WorkbookProtection))]
  [ChildElementInfo(typeof (BookViews))]
  [ChildElementInfo(typeof (Sheets))]
  [ChildElementInfo(typeof (FunctionGroups))]
  [ChildElementInfo(typeof (ExternalReferences))]
  [ChildElementInfo(typeof (DefinedNames))]
  [ChildElementInfo(typeof (CalculationProperties))]
  [ChildElementInfo(typeof (OleSize))]
  [ChildElementInfo(typeof (PivotCaches))]
  [ChildElementInfo(typeof (WebPublishing))]
  [ChildElementInfo(typeof (FileRecoveryProperties))]
  [ChildElementInfo(typeof (WebPublishObjects))]
  public class Workbook : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "conformance"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[18]
    {
      "fileVersion",
      "fileSharing",
      "workbookPr",
      "absPath",
      "workbookProtection",
      "bookViews",
      "sheets",
      "functionGroups",
      "externalReferences",
      "definedNames",
      "calcPr",
      "oleSize",
      "customWorkbookViews",
      "pivotCaches",
      "webPublishing",
      "fileRecoveryPr",
      "webPublishObjects",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[18]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 74,
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
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "workbook";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11114;

    public override string LocalName
    {
      get
      {
        return "workbook";
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
        return 11114;
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
        return Workbook.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Workbook.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "conformance")]
    public EnumValue<ConformanceClass> Conformance
    {
      get
      {
        return (EnumValue<ConformanceClass>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal Workbook(WorkbookPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorkbookPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorkbookPart WorkbookPart
    {
      get
      {
        return this.OpenXmlPart as WorkbookPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Workbook(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Workbook(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Workbook(string outerXml)
      : base(outerXml)
    {
    }

    public Workbook()
    {
    }

    public void Save(WorkbookPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "fileVersion" == name)
        return (OpenXmlElement) new FileVersion();
      if (22 == (int) namespaceId && "fileSharing" == name)
        return (OpenXmlElement) new FileSharing();
      if (22 == (int) namespaceId && "workbookPr" == name)
        return (OpenXmlElement) new WorkbookProperties();
      if (74 == (int) namespaceId && "absPath" == name)
        return (OpenXmlElement) new AbsolutePath();
      if (22 == (int) namespaceId && "workbookProtection" == name)
        return (OpenXmlElement) new WorkbookProtection();
      if (22 == (int) namespaceId && "bookViews" == name)
        return (OpenXmlElement) new BookViews();
      if (22 == (int) namespaceId && "sheets" == name)
        return (OpenXmlElement) new Sheets();
      if (22 == (int) namespaceId && "functionGroups" == name)
        return (OpenXmlElement) new FunctionGroups();
      if (22 == (int) namespaceId && "externalReferences" == name)
        return (OpenXmlElement) new ExternalReferences();
      if (22 == (int) namespaceId && "definedNames" == name)
        return (OpenXmlElement) new DefinedNames();
      if (22 == (int) namespaceId && "calcPr" == name)
        return (OpenXmlElement) new CalculationProperties();
      if (22 == (int) namespaceId && "oleSize" == name)
        return (OpenXmlElement) new OleSize();
      if (22 == (int) namespaceId && "customWorkbookViews" == name)
        return (OpenXmlElement) new CustomWorkbookViews();
      if (22 == (int) namespaceId && "pivotCaches" == name)
        return (OpenXmlElement) new PivotCaches();
      if (22 == (int) namespaceId && "webPublishing" == name)
        return (OpenXmlElement) new WebPublishing();
      if (22 == (int) namespaceId && "fileRecoveryPr" == name)
        return (OpenXmlElement) new FileRecoveryProperties();
      if (22 == (int) namespaceId && "webPublishObjects" == name)
        return (OpenXmlElement) new WebPublishObjects();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new WorkbookExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Workbook.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Workbook.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FileVersion FileVersion
    {
      get
      {
        return this.GetElement<FileVersion>(0);
      }
      set
      {
        this.SetElement<FileVersion>(0, value);
      }
    }

    public FileSharing FileSharing
    {
      get
      {
        return this.GetElement<FileSharing>(1);
      }
      set
      {
        this.SetElement<FileSharing>(1, value);
      }
    }

    public WorkbookProperties WorkbookProperties
    {
      get
      {
        return this.GetElement<WorkbookProperties>(2);
      }
      set
      {
        this.SetElement<WorkbookProperties>(2, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public AbsolutePath AbsolutePath
    {
      get
      {
        return this.GetElement<AbsolutePath>(3);
      }
      set
      {
        this.SetElement<AbsolutePath>(3, value);
      }
    }

    public WorkbookProtection WorkbookProtection
    {
      get
      {
        return this.GetElement<WorkbookProtection>(4);
      }
      set
      {
        this.SetElement<WorkbookProtection>(4, value);
      }
    }

    public BookViews BookViews
    {
      get
      {
        return this.GetElement<BookViews>(5);
      }
      set
      {
        this.SetElement<BookViews>(5, value);
      }
    }

    public Sheets Sheets
    {
      get
      {
        return this.GetElement<Sheets>(6);
      }
      set
      {
        this.SetElement<Sheets>(6, value);
      }
    }

    public FunctionGroups FunctionGroups
    {
      get
      {
        return this.GetElement<FunctionGroups>(7);
      }
      set
      {
        this.SetElement<FunctionGroups>(7, value);
      }
    }

    public ExternalReferences ExternalReferences
    {
      get
      {
        return this.GetElement<ExternalReferences>(8);
      }
      set
      {
        this.SetElement<ExternalReferences>(8, value);
      }
    }

    public DefinedNames DefinedNames
    {
      get
      {
        return this.GetElement<DefinedNames>(9);
      }
      set
      {
        this.SetElement<DefinedNames>(9, value);
      }
    }

    public CalculationProperties CalculationProperties
    {
      get
      {
        return this.GetElement<CalculationProperties>(10);
      }
      set
      {
        this.SetElement<CalculationProperties>(10, value);
      }
    }

    public OleSize OleSize
    {
      get
      {
        return this.GetElement<OleSize>(11);
      }
      set
      {
        this.SetElement<OleSize>(11, value);
      }
    }

    public CustomWorkbookViews CustomWorkbookViews
    {
      get
      {
        return this.GetElement<CustomWorkbookViews>(12);
      }
      set
      {
        this.SetElement<CustomWorkbookViews>(12, value);
      }
    }

    public PivotCaches PivotCaches
    {
      get
      {
        return this.GetElement<PivotCaches>(13);
      }
      set
      {
        this.SetElement<PivotCaches>(13, value);
      }
    }

    public WebPublishing WebPublishing
    {
      get
      {
        return this.GetElement<WebPublishing>(14);
      }
      set
      {
        this.SetElement<WebPublishing>(14, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "conformance" == name)
        return (OpenXmlSimpleType) new EnumValue<ConformanceClass>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Workbook>(deep);
    }
  }
}
