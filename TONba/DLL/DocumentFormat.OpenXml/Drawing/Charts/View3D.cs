// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.View3D
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (RightAngleAxes))]
  [ChildElementInfo(typeof (RotateY))]
  [ChildElementInfo(typeof (DepthPercent))]
  [ChildElementInfo(typeof (Perspective))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RotateX))]
  [ChildElementInfo(typeof (HeightPercent))]
  public class View3D : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "rotX",
      "hPercent",
      "rotY",
      "depthPercent",
      "rAngAx",
      "perspective",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "view3D";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10480;

    public override string LocalName
    {
      get
      {
        return "view3D";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10480;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public View3D()
    {
    }

    public View3D(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public View3D(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public View3D(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "rotX" == name)
        return (OpenXmlElement) new RotateX();
      if (11 == (int) namespaceId && "hPercent" == name)
        return (OpenXmlElement) new HeightPercent();
      if (11 == (int) namespaceId && "rotY" == name)
        return (OpenXmlElement) new RotateY();
      if (11 == (int) namespaceId && "depthPercent" == name)
        return (OpenXmlElement) new DepthPercent();
      if (11 == (int) namespaceId && "rAngAx" == name)
        return (OpenXmlElement) new RightAngleAxes();
      if (11 == (int) namespaceId && "perspective" == name)
        return (OpenXmlElement) new Perspective();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return View3D.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return View3D.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RotateX RotateX
    {
      get
      {
        return this.GetElement<RotateX>(0);
      }
      set
      {
        this.SetElement<RotateX>(0, value);
      }
    }

    public HeightPercent HeightPercent
    {
      get
      {
        return this.GetElement<HeightPercent>(1);
      }
      set
      {
        this.SetElement<HeightPercent>(1, value);
      }
    }

    public RotateY RotateY
    {
      get
      {
        return this.GetElement<RotateY>(2);
      }
      set
      {
        this.SetElement<RotateY>(2, value);
      }
    }

    public DepthPercent DepthPercent
    {
      get
      {
        return this.GetElement<DepthPercent>(3);
      }
      set
      {
        this.SetElement<DepthPercent>(3, value);
      }
    }

    public RightAngleAxes RightAngleAxes
    {
      get
      {
        return this.GetElement<RightAngleAxes>(4);
      }
      set
      {
        this.SetElement<RightAngleAxes>(4, value);
      }
    }

    public Perspective Perspective
    {
      get
      {
        return this.GetElement<Perspective>(5);
      }
      set
      {
        this.SetElement<Perspective>(5, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(6);
      }
      set
      {
        this.SetElement<ExtensionList>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<View3D>(deep);
    }
  }
}
