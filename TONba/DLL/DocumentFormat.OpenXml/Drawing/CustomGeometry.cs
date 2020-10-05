// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.CustomGeometry
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ShapeGuideList))]
  [ChildElementInfo(typeof (AdjustValueList))]
  [ChildElementInfo(typeof (AdjustHandleList))]
  [ChildElementInfo(typeof (ConnectionSiteList))]
  [ChildElementInfo(typeof (Rectangle))]
  [ChildElementInfo(typeof (PathList))]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomGeometry : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "avLst",
      "gdLst",
      "ahLst",
      "cxnLst",
      "rect",
      "pathLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "custGeom";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10085;

    public override string LocalName
    {
      get
      {
        return "custGeom";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10085;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CustomGeometry()
    {
    }

    public CustomGeometry(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomGeometry(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomGeometry(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "avLst" == name)
        return (OpenXmlElement) new AdjustValueList();
      if (10 == (int) namespaceId && "gdLst" == name)
        return (OpenXmlElement) new ShapeGuideList();
      if (10 == (int) namespaceId && "ahLst" == name)
        return (OpenXmlElement) new AdjustHandleList();
      if (10 == (int) namespaceId && "cxnLst" == name)
        return (OpenXmlElement) new ConnectionSiteList();
      if (10 == (int) namespaceId && "rect" == name)
        return (OpenXmlElement) new Rectangle();
      if (10 == (int) namespaceId && "pathLst" == name)
        return (OpenXmlElement) new PathList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomGeometry.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomGeometry.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AdjustValueList AdjustValueList
    {
      get
      {
        return this.GetElement<AdjustValueList>(0);
      }
      set
      {
        this.SetElement<AdjustValueList>(0, value);
      }
    }

    public ShapeGuideList ShapeGuideList
    {
      get
      {
        return this.GetElement<ShapeGuideList>(1);
      }
      set
      {
        this.SetElement<ShapeGuideList>(1, value);
      }
    }

    public AdjustHandleList AdjustHandleList
    {
      get
      {
        return this.GetElement<AdjustHandleList>(2);
      }
      set
      {
        this.SetElement<AdjustHandleList>(2, value);
      }
    }

    public ConnectionSiteList ConnectionSiteList
    {
      get
      {
        return this.GetElement<ConnectionSiteList>(3);
      }
      set
      {
        this.SetElement<ConnectionSiteList>(3, value);
      }
    }

    public Rectangle Rectangle
    {
      get
      {
        return this.GetElement<Rectangle>(4);
      }
      set
      {
        this.SetElement<Rectangle>(4, value);
      }
    }

    public PathList PathList
    {
      get
      {
        return this.GetElement<PathList>(5);
      }
      set
      {
        this.SetElement<PathList>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomGeometry>(deep);
    }
  }
}
