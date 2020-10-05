// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.StylesheetExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.DifferentialFormats), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SlicerStyles), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Excel.DifferentialFormats), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TimelineStyles), FileFormatVersions.Office2013)]
  public class StylesheetExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11518;

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
        return 11518;
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
        return StylesheetExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StylesheetExtension.attributeNamespaceIds;
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

    public StylesheetExtension()
    {
    }

    public StylesheetExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StylesheetExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StylesheetExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "dxfs" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.DifferentialFormats();
      if (53 == (int) namespaceId && "slicerStyles" == name)
        return (OpenXmlElement) new SlicerStyles();
      if (71 == (int) namespaceId && "dxfs" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Excel.DifferentialFormats();
      if (71 == (int) namespaceId && "timelineStyles" == name)
        return (OpenXmlElement) new TimelineStyles();
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
      return (OpenXmlElement) this.CloneImp<StylesheetExtension>(deep);
    }
  }
}
