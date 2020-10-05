// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TimelineStyles
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (TimelineStyle), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class TimelineStyles : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "defaultTimelineStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "timelineStyles";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13366;

    public override string LocalName
    {
      get
      {
        return "timelineStyles";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13366;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return TimelineStyles.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TimelineStyles.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "defaultTimelineStyle")]
    public StringValue DefaultTimelineStyle
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

    public TimelineStyles()
    {
    }

    public TimelineStyles(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimelineStyles(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimelineStyles(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "timelineStyle" == name)
        return (OpenXmlElement) new TimelineStyle();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "defaultTimelineStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimelineStyles>(deep);
    }
  }
}
