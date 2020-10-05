// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Frame
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FrameSize))]
  [ChildElementInfo(typeof (MarginWidth))]
  [ChildElementInfo(typeof (MarginHeight))]
  [ChildElementInfo(typeof (LinkedToFile))]
  [ChildElementInfo(typeof (FrameName))]
  [ChildElementInfo(typeof (SourceFileReference))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ScrollbarVisibility))]
  [ChildElementInfo(typeof (NoResizeAllowed))]
  public class Frame : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "sz",
      "name",
      "sourceFileName",
      "marW",
      "marH",
      "scrollbar",
      "noResizeAllowed",
      "linkedToFile"
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
    private const string tagName = "frame";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11910;

    public override string LocalName
    {
      get
      {
        return "frame";
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
        return 11910;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Frame()
    {
    }

    public Frame(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Frame(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Frame(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FrameSize();
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new FrameName();
      if (23 == (int) namespaceId && "sourceFileName" == name)
        return (OpenXmlElement) new SourceFileReference();
      if (23 == (int) namespaceId && "marW" == name)
        return (OpenXmlElement) new MarginWidth();
      if (23 == (int) namespaceId && "marH" == name)
        return (OpenXmlElement) new MarginHeight();
      if (23 == (int) namespaceId && "scrollbar" == name)
        return (OpenXmlElement) new ScrollbarVisibility();
      if (23 == (int) namespaceId && "noResizeAllowed" == name)
        return (OpenXmlElement) new NoResizeAllowed();
      if (23 == (int) namespaceId && "linkedToFile" == name)
        return (OpenXmlElement) new LinkedToFile();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Frame.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Frame.eleNamespaceIds;
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

    public FrameName FrameName
    {
      get
      {
        return this.GetElement<FrameName>(1);
      }
      set
      {
        this.SetElement<FrameName>(1, value);
      }
    }

    public SourceFileReference SourceFileReference
    {
      get
      {
        return this.GetElement<SourceFileReference>(2);
      }
      set
      {
        this.SetElement<SourceFileReference>(2, value);
      }
    }

    public MarginWidth MarginWidth
    {
      get
      {
        return this.GetElement<MarginWidth>(3);
      }
      set
      {
        this.SetElement<MarginWidth>(3, value);
      }
    }

    public MarginHeight MarginHeight
    {
      get
      {
        return this.GetElement<MarginHeight>(4);
      }
      set
      {
        this.SetElement<MarginHeight>(4, value);
      }
    }

    public ScrollbarVisibility ScrollbarVisibility
    {
      get
      {
        return this.GetElement<ScrollbarVisibility>(5);
      }
      set
      {
        this.SetElement<ScrollbarVisibility>(5, value);
      }
    }

    public NoResizeAllowed NoResizeAllowed
    {
      get
      {
        return this.GetElement<NoResizeAllowed>(6);
      }
      set
      {
        this.SetElement<NoResizeAllowed>(6, value);
      }
    }

    public LinkedToFile LinkedToFile
    {
      get
      {
        return this.GetElement<LinkedToFile>(7);
      }
      set
      {
        this.SetElement<LinkedToFile>(7, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Frame>(deep);
    }
  }
}
