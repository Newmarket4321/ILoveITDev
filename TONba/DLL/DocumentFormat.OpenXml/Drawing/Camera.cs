// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Camera
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Rotation))]
  [GeneratedCode("DomGen", "2.0")]
  public class Camera : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "prst",
      "fov",
      "zoom"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "rot"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "camera";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10193;

    public override string LocalName
    {
      get
      {
        return "camera";
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
        return 10193;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Camera.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Camera.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prst")]
    public EnumValue<PresetCameraValues> Preset
    {
      get
      {
        return (EnumValue<PresetCameraValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fov")]
    public Int32Value FieldOfView
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoom")]
    public Int32Value Zoom
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Camera()
    {
    }

    public Camera(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Camera(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Camera(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "rot" == name)
        return (OpenXmlElement) new Rotation();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Camera.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Camera.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Rotation Rotation
    {
      get
      {
        return this.GetElement<Rotation>(0);
      }
      set
      {
        this.SetElement<Rotation>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prst" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetCameraValues>();
      if ((int) namespaceId == 0 && "fov" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "zoom" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Camera>(deep);
    }
  }
}
