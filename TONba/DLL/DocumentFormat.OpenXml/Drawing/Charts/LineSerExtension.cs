﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (DataLabelsRange), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredSeriesTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredCategoryTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CategoryFilterExceptions), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class LineSerExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10544;

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
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10544;
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
        return LineSerExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LineSerExtension.attributeNamespaceIds;
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

    public LineSerExtension()
    {
    }

    public LineSerExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LineSerExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LineSerExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "filteredSeriesTitle" == name)
        return (OpenXmlElement) new FilteredSeriesTitle();
      if (64 == (int) namespaceId && "filteredCategoryTitle" == name)
        return (OpenXmlElement) new FilteredCategoryTitle();
      if (64 == (int) namespaceId && "datalabelsRange" == name)
        return (OpenXmlElement) new DataLabelsRange();
      if (64 == (int) namespaceId && "categoryFilterExceptions" == name)
        return (OpenXmlElement) new CategoryFilterExceptions();
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
      return (OpenXmlElement) this.CloneImp<LineSerExtension>(deep);
    }
  }
}
