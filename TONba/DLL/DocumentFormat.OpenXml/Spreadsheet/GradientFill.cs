// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.GradientFill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GradientStop))]
  public class GradientFill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "type",
      "degree",
      "left",
      "right",
      "top",
      "bottom"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "gradientFill";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11310;

    public override string LocalName
    {
      get
      {
        return "gradientFill";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11310;
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
        return GradientFill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GradientFill.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<GradientValues> Type
    {
      get
      {
        return (EnumValue<GradientValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "degree")]
    public DoubleValue Degree
    {
      get
      {
        return (DoubleValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "left")]
    public DoubleValue Left
    {
      get
      {
        return (DoubleValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "right")]
    public DoubleValue Right
    {
      get
      {
        return (DoubleValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "top")]
    public DoubleValue Top
    {
      get
      {
        return (DoubleValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bottom")]
    public DoubleValue Bottom
    {
      get
      {
        return (DoubleValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public GradientFill()
    {
    }

    public GradientFill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GradientFill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GradientFill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "stop" == name)
        return (OpenXmlElement) new GradientStop();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<GradientValues>();
      if ((int) namespaceId == 0 && "degree" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "left" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "right" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "top" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "bottom" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GradientFill>(deep);
    }
  }
}
