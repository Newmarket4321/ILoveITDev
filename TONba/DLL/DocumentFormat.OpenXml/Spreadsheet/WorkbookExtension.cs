// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.WorkbookExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Excel.SlicerCaches), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.WorkbookProperties), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Excel.PivotCaches), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotTableReferences), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.DefinedNames), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.PivotCaches), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.SlicerCaches), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TimelineCachePivotCaches), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TimelineCacheReferences), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Excel.WorkbookProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataModel), FileFormatVersions.Office2013)]
  public class WorkbookExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11536;

    public override string LocalName
    {
      get
      {
        return "ext";
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
        return 11536;
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
        return WorkbookExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WorkbookExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public WorkbookExtension()
    {
    }

    public WorkbookExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WorkbookExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WorkbookExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "definedNames" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.DefinedNames();
      if (53 == (int) namespaceId && "pivotCaches" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.PivotCaches();
      if (53 == (int) namespaceId && "slicerCaches" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.SlicerCaches();
      if (71 == (int) namespaceId && "slicerCaches" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Excel.SlicerCaches();
      if (53 == (int) namespaceId && "workbookPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.WorkbookProperties();
      if (71 == (int) namespaceId && "pivotCaches" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Excel.PivotCaches();
      if (71 == (int) namespaceId && "pivotTableReferences" == name)
        return (OpenXmlElement) new PivotTableReferences();
      if (71 == (int) namespaceId && "timelineCachePivotCaches" == name)
        return (OpenXmlElement) new TimelineCachePivotCaches();
      if (71 == (int) namespaceId && "timelineCacheRefs" == name)
        return (OpenXmlElement) new TimelineCacheReferences();
      if (71 == (int) namespaceId && "workbookPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Excel.WorkbookProperties();
      if (71 == (int) namespaceId && "dataModel" == name)
        return (OpenXmlElement) new DataModel();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WorkbookExtension>(deep);
    }
  }
}
