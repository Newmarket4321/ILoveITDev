﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Camera))]
  [ChildElementInfo(typeof (LightRig))]
  [ChildElementInfo(typeof (Backdrop))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class HiddenScene3D : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "camera",
      "lightRig",
      "backdrop",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "hiddenScene3d";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12789;

    public override string LocalName
    {
      get
      {
        return "hiddenScene3d";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12789;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public HiddenScene3D()
    {
    }

    public HiddenScene3D(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HiddenScene3D(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HiddenScene3D(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "camera" == name)
        return (OpenXmlElement) new Camera();
      if (10 == (int) namespaceId && "lightRig" == name)
        return (OpenXmlElement) new LightRig();
      if (10 == (int) namespaceId && "backdrop" == name)
        return (OpenXmlElement) new Backdrop();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HiddenScene3D.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HiddenScene3D.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Camera Camera
    {
      get
      {
        return this.GetElement<Camera>(0);
      }
      set
      {
        this.SetElement<Camera>(0, value);
      }
    }

    public LightRig LightRig
    {
      get
      {
        return this.GetElement<LightRig>(1);
      }
      set
      {
        this.SetElement<LightRig>(1, value);
      }
    }

    public Backdrop Backdrop
    {
      get
      {
        return this.GetElement<Backdrop>(2);
      }
      set
      {
        this.SetElement<Backdrop>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HiddenScene3D>(deep);
    }
  }
}
