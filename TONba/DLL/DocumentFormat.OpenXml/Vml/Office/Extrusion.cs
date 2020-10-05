// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Extrusion
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class Extrusion : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[31]
    {
      "ext",
      "on",
      "type",
      "render",
      "viewpointorigin",
      "viewpoint",
      "skewangle",
      "skewamt",
      "foredepth",
      "backdepth",
      "orientation",
      "orientationangle",
      "lockrotationcenter",
      "autorotationcenter",
      "rotationcenter",
      "rotationangle",
      "color",
      "shininess",
      "specularity",
      "diffusity",
      "metal",
      "edge",
      "facet",
      "lightface",
      "brightness",
      "lightposition",
      "lightlevel",
      "lightharsh",
      "lightposition2",
      "lightlevel2",
      "lightharsh2"
    };
    private static byte[] attributeNamespaceIds = new byte[31]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "extrusion";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12476;

    public override string LocalName
    {
      get
      {
        return "extrusion";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12476;
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
        return Extrusion.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Extrusion.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
      get
      {
        return (TrueFalseValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<ExtrusionValues> Type
    {
      get
      {
        return (EnumValue<ExtrusionValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "render")]
    public EnumValue<ExtrusionRenderValues> Render
    {
      get
      {
        return (EnumValue<ExtrusionRenderValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "viewpointorigin")]
    public StringValue ViewpointOrigin
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "viewpoint")]
    public StringValue Viewpoint
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "skewangle")]
    public SingleValue SkewAngle
    {
      get
      {
        return (SingleValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "skewamt")]
    public StringValue SkewAmount
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "foredepth")]
    public StringValue ForceDepth
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "backdepth")]
    public StringValue BackDepth
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "orientation")]
    public StringValue Orientation
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "orientationangle")]
    public SingleValue OrientationAngle
    {
      get
      {
        return (SingleValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lockrotationcenter")]
    public TrueFalseValue LockRotationCenter
    {
      get
      {
        return (TrueFalseValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autorotationcenter")]
    public TrueFalseValue AutoRotationCenter
    {
      get
      {
        return (TrueFalseValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotationcenter")]
    public StringValue RotationCenter
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotationangle")]
    public StringValue RotationAngle
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "color")]
    public StringValue Color
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shininess")]
    public SingleValue Shininess
    {
      get
      {
        return (SingleValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "specularity")]
    public StringValue Specularity
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "diffusity")]
    public StringValue Diffusity
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "metal")]
    public TrueFalseValue Metal
    {
      get
      {
        return (TrueFalseValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "edge")]
    public StringValue Edge
    {
      get
      {
        return (StringValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "facet")]
    public StringValue Facet
    {
      get
      {
        return (StringValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightface")]
    public TrueFalseValue LightFace
    {
      get
      {
        return (TrueFalseValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "brightness")]
    public StringValue Brightness
    {
      get
      {
        return (StringValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightposition")]
    public StringValue LightPosition
    {
      get
      {
        return (StringValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightlevel")]
    public StringValue LightLevel
    {
      get
      {
        return (StringValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightharsh")]
    public TrueFalseValue LightHarsh
    {
      get
      {
        return (TrueFalseValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightposition2")]
    public StringValue LightPosition2
    {
      get
      {
        return (StringValue) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightlevel2")]
    public StringValue LightLevel2
    {
      get
      {
        return (StringValue) this.Attributes[29];
      }
      set
      {
        this.Attributes[29] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lightharsh2")]
    public TrueFalseValue LightHarsh2
    {
      get
      {
        return (TrueFalseValue) this.Attributes[30];
      }
      set
      {
        this.Attributes[30] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "on" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtrusionValues>();
      if ((int) namespaceId == 0 && "render" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtrusionRenderValues>();
      if ((int) namespaceId == 0 && "viewpointorigin" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "viewpoint" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "skewangle" == name)
        return (OpenXmlSimpleType) new SingleValue();
      if ((int) namespaceId == 0 && "skewamt" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "foredepth" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "backdepth" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "orientation" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "orientationangle" == name)
        return (OpenXmlSimpleType) new SingleValue();
      if ((int) namespaceId == 0 && "lockrotationcenter" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "autorotationcenter" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "rotationcenter" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rotationangle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "shininess" == name)
        return (OpenXmlSimpleType) new SingleValue();
      if ((int) namespaceId == 0 && "specularity" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "diffusity" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "metal" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "edge" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "facet" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightface" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "brightness" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightposition" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightlevel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightharsh" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "lightposition2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightlevel2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lightharsh2" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Extrusion>(deep);
    }
  }
}
