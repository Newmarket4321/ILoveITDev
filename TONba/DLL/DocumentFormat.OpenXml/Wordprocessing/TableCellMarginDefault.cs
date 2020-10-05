// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TableCellRightMargin))]
  [ChildElementInfo(typeof (TopMargin))]
  [ChildElementInfo(typeof (TableCellLeftMargin))]
  [ChildElementInfo(typeof (StartMargin), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BottomMargin))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EndMargin), FileFormatVersions.Office2010)]
  public class TableCellMarginDefault : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "top",
      "left",
      "start",
      "bottom",
      "right",
      "end"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblCellMar";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11727;

    public override string LocalName
    {
      get
      {
        return "tblCellMar";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11727;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableCellMarginDefault()
    {
    }

    public TableCellMarginDefault(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellMarginDefault(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellMarginDefault(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopMargin();
      if (23 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new TableCellLeftMargin();
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlElement) new StartMargin();
      if (23 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomMargin();
      if (23 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new TableCellRightMargin();
      if (23 == (int) namespaceId && "end" == name)
        return (OpenXmlElement) new EndMargin();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCellMarginDefault.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCellMarginDefault.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TopMargin TopMargin
    {
      get
      {
        return this.GetElement<TopMargin>(0);
      }
      set
      {
        this.SetElement<TopMargin>(0, value);
      }
    }

    public TableCellLeftMargin TableCellLeftMargin
    {
      get
      {
        return this.GetElement<TableCellLeftMargin>(1);
      }
      set
      {
        this.SetElement<TableCellLeftMargin>(1, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public StartMargin StartMargin
    {
      get
      {
        return this.GetElement<StartMargin>(2);
      }
      set
      {
        this.SetElement<StartMargin>(2, value);
      }
    }

    public BottomMargin BottomMargin
    {
      get
      {
        return this.GetElement<BottomMargin>(3);
      }
      set
      {
        this.SetElement<BottomMargin>(3, value);
      }
    }

    public TableCellRightMargin TableCellRightMargin
    {
      get
      {
        return this.GetElement<TableCellRightMargin>(4);
      }
      set
      {
        this.SetElement<TableCellRightMargin>(4, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public EndMargin EndMargin
    {
      get
      {
        return this.GetElement<EndMargin>(5);
      }
      set
      {
        this.SetElement<EndMargin>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellMarginDefault>(deep);
    }
  }
}
