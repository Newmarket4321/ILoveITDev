﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Scene3D
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Camera), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LightRig), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Scene3D : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "camera",
      "lightRig"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "scene3d";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12925;

    public override string LocalName
    {
      get
      {
        return "scene3d";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12925;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Scene3D()
    {
    }

    public Scene3D(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Scene3D(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Scene3D(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "camera" == name)
        return (OpenXmlElement) new Camera();
      if (52 == (int) namespaceId && "lightRig" == name)
        return (OpenXmlElement) new LightRig();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Scene3D.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Scene3D.eleNamespaceIds;
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Scene3D>(deep);
    }
  }
}
