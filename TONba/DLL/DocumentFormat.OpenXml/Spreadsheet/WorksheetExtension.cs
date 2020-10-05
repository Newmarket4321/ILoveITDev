// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.WorksheetExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SparklineGroups), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SlicerList), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TimelineReferences), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConditionalFormattings), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.DataValidations), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.ProtectedRanges), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.IgnoredErrors), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (WebExtensions), FileFormatVersions.Office2013)]
  public class WorksheetExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11504;

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
        return 11504;
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
        return WorksheetExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WorksheetExtension.attributeNamespaceIds;
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

    public WorksheetExtension()
    {
    }

    public WorksheetExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WorksheetExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WorksheetExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "conditionalFormattings" == name)
        return (OpenXmlElement) new ConditionalFormattings();
      if (53 == (int) namespaceId && "dataValidations" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.DataValidations();
      if (53 == (int) namespaceId && "sparklineGroups" == name)
        return (OpenXmlElement) new SparklineGroups();
      if (53 == (int) namespaceId && "slicerList" == name)
        return (OpenXmlElement) new SlicerList();
      if (53 == (int) namespaceId && "protectedRanges" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.ProtectedRanges();
      if (53 == (int) namespaceId && "ignoredErrors" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.IgnoredErrors();
      if (71 == (int) namespaceId && "webExtensions" == name)
        return (OpenXmlElement) new WebExtensions();
      if (71 == (int) namespaceId && "timelineRefs" == name)
        return (OpenXmlElement) new TimelineReferences();
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
      return (OpenXmlElement) this.CloneImp<WorksheetExtension>(deep);
    }
  }
}
