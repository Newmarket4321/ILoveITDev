// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.View3DProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class View3DProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "rotX",
      "rotY",
      "rAngAx",
      "perspective",
      "heightPercent",
      "depthPercent"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "view3D";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13278;

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
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13278;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return View3DProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return View3DProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rotX")]
    public SByteValue RotX
    {
      get
      {
        return (SByteValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotY")]
    public UInt16Value RotY
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rAngAx")]
    public EnumValue<Boolean> RightAngleAxes
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "perspective")]
    public ByteValue Perspective
    {
      get
      {
        return (ByteValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "heightPercent")]
    public UInt16Value HeightPercent
    {
      get
      {
        return (UInt16Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "depthPercent")]
    public UInt16Value DepthPercent
    {
      get
      {
        return (UInt16Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rotX" == name)
        return (OpenXmlSimpleType) new SByteValue();
      if ((int) namespaceId == 0 && "rotY" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "rAngAx" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "perspective" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "heightPercent" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "depthPercent" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<View3DProperties>(deep);
    }
  }
}
