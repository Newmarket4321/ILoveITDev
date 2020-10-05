// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Frameset
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FramesetSplitbar))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Frame))]
  [ChildElementInfo(typeof (FrameSize))]
  [ChildElementInfo(typeof (FrameLayout))]
  [ChildElementInfo(typeof (Frameset))]
  public class Frameset : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "sz",
      "framesetSplitbar",
      "frameLayout",
      "frameset",
      "frame"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "frameset";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11909;

    public override string LocalName
    {
      get
      {
        return "frameset";
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
        return 11909;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Frameset()
    {
    }

    public Frameset(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Frameset(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Frameset(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FrameSize();
      if (23 == (int) namespaceId && "framesetSplitbar" == name)
        return (OpenXmlElement) new FramesetSplitbar();
      if (23 == (int) namespaceId && "frameLayout" == name)
        return (OpenXmlElement) new FrameLayout();
      if (23 == (int) namespaceId && "frameset" == name)
        return (OpenXmlElement) new Frameset();
      if (23 == (int) namespaceId && "frame" == name)
        return (OpenXmlElement) new Frame();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Frameset.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Frameset.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FrameSize FrameSize
    {
      get
      {
        return this.GetElement<FrameSize>(0);
      }
      set
      {
        this.SetElement<FrameSize>(0, value);
      }
    }

    public FramesetSplitbar FramesetSplitbar
    {
      get
      {
        return this.GetElement<FramesetSplitbar>(1);
      }
      set
      {
        this.SetElement<FramesetSplitbar>(1, value);
      }
    }

    public FrameLayout FrameLayout
    {
      get
      {
        return this.GetElement<FrameLayout>(2);
      }
      set
      {
        this.SetElement<FrameLayout>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Frameset>(deep);
    }
  }
}
