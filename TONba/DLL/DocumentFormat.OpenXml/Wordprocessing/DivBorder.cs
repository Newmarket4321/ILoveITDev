﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DivBorder
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TopBorder))]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  [GeneratedCode("DomGen", "2.0")]
  public class DivBorder : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "top",
      "left",
      "bottom",
      "right"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "divBdr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11970;

    public override string LocalName
    {
      get
      {
        return "divBdr";
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
        return 11970;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DivBorder()
    {
    }

    public DivBorder(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DivBorder(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DivBorder(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopBorder();
      if (23 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftBorder();
      if (23 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (23 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightBorder();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DivBorder.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DivBorder.eleNamespaceIds;
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

    public BottomBorder BottomBorder
    {
      get
      {
        return this.GetElement<BottomBorder>(2);
      }
      set
      {
        this.SetElement<BottomBorder>(2, value);
      }
    }

    public RightBorder RightBorder
    {
      get
      {
        return this.GetElement<RightBorder>(3);
      }
      set
      {
        this.SetElement<RightBorder>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DivBorder>(deep);
    }
  }
}
