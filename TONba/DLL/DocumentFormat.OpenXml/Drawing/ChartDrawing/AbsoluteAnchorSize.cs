// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [ChildElementInfo(typeof (Extent))]
  [ChildElementInfo(typeof (FromAnchor))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShape))]
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (ConnectionShape))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class AbsoluteAnchorSize : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "from",
      "ext",
      "sp",
      "grpSp",
      "graphicFrame",
      "cxnSp",
      "pic",
      "contentPart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 47
    };
    private const string tagName = "absSizeAnchor";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10653;

    public override string LocalName
    {
      get
      {
        return "absSizeAnchor";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 12;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10653;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AbsoluteAnchorSize()
    {
    }

    public AbsoluteAnchorSize(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AbsoluteAnchorSize(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AbsoluteAnchorSize(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "from" == name)
        return (OpenXmlElement) new FromAnchor();
      if (12 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new Extent();
      if (12 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (12 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (12 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (12 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (12 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (47 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AbsoluteAnchorSize.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AbsoluteAnchorSize.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FromAnchor FromAnchor
    {
      get
      {
        return this.GetElement<FromAnchor>(0);
      }
      set
      {
        this.SetElement<FromAnchor>(0, value);
      }
    }

    public Extent Extent
    {
      get
      {
        return this.GetElement<Extent>(1);
      }
      set
      {
        this.SetElement<Extent>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AbsoluteAnchorSize>(deep);
    }
  }
}
