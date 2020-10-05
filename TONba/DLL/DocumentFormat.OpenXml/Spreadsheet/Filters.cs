// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Filters
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Filter))]
  [ChildElementInfo(typeof (DateGroupItem))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.Filter), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Filters : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "blank",
      "calendarType"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "filters";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11431;

    public override string LocalName
    {
      get
      {
        return "filters";
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
        return 11431;
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
        return Filters.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Filters.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "blank")]
    public BooleanValue Blank
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "calendarType")]
    public EnumValue<CalendarValues> CalendarType
    {
      get
      {
        return (EnumValue<CalendarValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public Filters()
    {
    }

    public Filters(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Filters(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Filters(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "filter" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.Filter();
      if (22 == (int) namespaceId && "filter" == name)
        return (OpenXmlElement) new Filter();
      if (22 == (int) namespaceId && "dateGroupItem" == name)
        return (OpenXmlElement) new DateGroupItem();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "blank" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "calendarType" == name)
        return (OpenXmlSimpleType) new EnumValue<CalendarValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Filters>(deep);
    }
  }
}
