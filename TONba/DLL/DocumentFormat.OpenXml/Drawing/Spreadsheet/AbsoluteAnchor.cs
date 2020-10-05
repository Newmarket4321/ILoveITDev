// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.AbsoluteAnchor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Position))]
  [ChildElementInfo(typeof (Extent))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShape))]
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (ConnectionShape))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (ClientData))]
  public class AbsoluteAnchor : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "pos",
      "ext",
      "sp",
      "grpSp",
      "graphicFrame",
      "cxnSp",
      "pic",
      "contentPart",
      "clientData"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18,
      (byte) 18
    };
    private const string tagName = "absoluteAnchor";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10788;

    public override string LocalName
    {
      get
      {
        return "absoluteAnchor";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10788;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AbsoluteAnchor()
    {
    }

    public AbsoluteAnchor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AbsoluteAnchor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AbsoluteAnchor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new Position();
      if (18 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new Extent();
      if (18 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (18 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (18 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (18 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (18 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (18 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (18 == (int) namespaceId && "clientData" == name)
        return (OpenXmlElement) new ClientData();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AbsoluteAnchor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AbsoluteAnchor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(0);
      }
      set
      {
        this.SetElement<Position>(0, value);
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
      return (OpenXmlElement) this.CloneImp<AbsoluteAnchor>(deep);
    }
  }
}
