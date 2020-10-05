// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.BorderPropertiesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Color))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class BorderPropertiesType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "style"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "color"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return BorderPropertiesType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BorderPropertiesType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "style")]
    public EnumValue<BorderStyleValues> Style
    {
      get
      {
        return (EnumValue<BorderStyleValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BorderPropertiesType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BorderPropertiesType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Color Color
    {
      get
      {
        return this.GetElement<Color>(0);
      }
      set
      {
        this.SetElement<Color>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "style" == name)
        return (OpenXmlSimpleType) new EnumValue<BorderStyleValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected BorderPropertiesType()
    {
    }

    protected BorderPropertiesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected BorderPropertiesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected BorderPropertiesType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
