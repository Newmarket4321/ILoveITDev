﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableBorders
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TopBorder))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (StartBorder), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (EndBorder), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (InsideVerticalBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  [ChildElementInfo(typeof (InsideHorizontalBorder))]
  public class TableBorders : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "top",
      "left",
      "start",
      "bottom",
      "right",
      "end",
      "insideH",
      "insideV"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblBorders";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11725;

    public override string LocalName
    {
      get
      {
        return "tblBorders";
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
        return 11725;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableBorders()
    {
    }

    public TableBorders(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableBorders(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableBorders(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopBorder();
      if (23 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftBorder();
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlElement) new StartBorder();
      if (23 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (23 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightBorder();
      if (23 == (int) namespaceId && "end" == name)
        return (OpenXmlElement) new EndBorder();
      if (23 == (int) namespaceId && "insideH" == name)
        return (OpenXmlElement) new InsideHorizontalBorder();
      if (23 == (int) namespaceId && "insideV" == name)
        return (OpenXmlElement) new InsideVerticalBorder();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableBorders.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableBorders.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TopBorder TopBorder
    {
      get
      {
        return this.GetElement<TopBorder>(0);
      }
      set
      {
        this.SetElement<TopBorder>(0, value);
      }
    }

    public LeftBorder LeftBorder
    {
      get
      {
        return this.GetElement<LeftBorder>(1);
      }
      set
      {
        this.SetElement<LeftBorder>(1, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public StartBorder StartBorder
    {
      get
      {
        return this.GetElement<StartBorder>(2);
      }
      set
      {
        this.SetElement<StartBorder>(2, value);
      }
    }

    public BottomBorder BottomBorder
    {
      get
      {
        return this.GetElement<BottomBorder>(3);
      }
      set
      {
        this.SetElement<BottomBorder>(3, value);
      }
    }

    public RightBorder RightBorder
    {
      get
      {
        return this.GetElement<RightBorder>(4);
      }
      set
      {
        this.SetElement<RightBorder>(4, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public EndBorder EndBorder
    {
      get
      {
        return this.GetElement<EndBorder>(5);
      }
      set
      {
        this.SetElement<EndBorder>(5, value);
      }
    }

    public InsideHorizontalBorder InsideHorizontalBorder
    {
      get
      {
        return this.GetElement<InsideHorizontalBorder>(6);
      }
      set
      {
        this.SetElement<InsideHorizontalBorder>(6, value);
      }
    }

    public InsideVerticalBorder InsideVerticalBorder
    {
      get
      {
        return this.GetElement<InsideVerticalBorder>(7);
      }
      set
      {
        this.SetElement<InsideVerticalBorder>(7, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableBorders>(deep);
    }
  }
}
