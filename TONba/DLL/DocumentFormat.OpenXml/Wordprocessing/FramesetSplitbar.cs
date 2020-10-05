// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FlatBorders))]
  [ChildElementInfo(typeof (Width))]
  [ChildElementInfo(typeof (NoBorder))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Color))]
  public class FramesetSplitbar : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "w",
      "color",
      "noBorder",
      "flatBorders"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "framesetSplitbar";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11907;

    public override string LocalName
    {
      get
      {
        return "framesetSplitbar";
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
        return 11907;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FramesetSplitbar()
    {
    }

    public FramesetSplitbar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FramesetSplitbar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FramesetSplitbar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlElement) new Width();
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      if (23 == (int) namespaceId && "noBorder" == name)
        return (OpenXmlElement) new NoBorder();
      if (23 == (int) namespaceId && "flatBorders" == name)
        return (OpenXmlElement) new FlatBorders();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FramesetSplitbar.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FramesetSplitbar.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Width Width
    {
      get
      {
        return this.GetElement<Width>(0);
      }
      set
      {
        this.SetElement<Width>(0, value);
      }
    }

    public Color Color
    {
      get
      {
        return this.GetElement<Color>(1);
      }
      set
      {
        this.SetElement<Color>(1, value);
      }
    }

    public NoBorder NoBorder
    {
      get
      {
        return this.GetElement<NoBorder>(2);
      }
      set
      {
        this.SetElement<NoBorder>(2, value);
      }
    }

    public FlatBorders FlatBorders
    {
      get
      {
        return this.GetElement<FlatBorders>(3);
      }
      set
      {
        this.SetElement<FlatBorders>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FramesetSplitbar>(deep);
    }
  }
}
