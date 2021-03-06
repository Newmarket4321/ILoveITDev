﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (AxisDataSourceType), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class FilteredCategoryTitle : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "cat"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 64
    };
    private const string tagName = "filteredCategoryTitle";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13217;

    public override string LocalName
    {
      get
      {
        return "filteredCategoryTitle";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13217;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public FilteredCategoryTitle()
    {
    }

    public FilteredCategoryTitle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FilteredCategoryTitle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FilteredCategoryTitle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "cat" == name)
        return (OpenXmlElement) new AxisDataSourceType();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FilteredCategoryTitle.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FilteredCategoryTitle.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AxisDataSourceType AxisDataSourceType
    {
      get
      {
        return this.GetElement<AxisDataSourceType>(0);
      }
      set
      {
        this.SetElement<AxisDataSourceType>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FilteredCategoryTitle>(deep);
    }
  }
}
