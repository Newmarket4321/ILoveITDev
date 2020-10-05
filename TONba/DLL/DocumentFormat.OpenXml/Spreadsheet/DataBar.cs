// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DataBar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ConditionalFormatValueObject))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Color))]
  public class DataBar : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "minLength",
      "maxLength",
      "showValue"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "dataBar";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11399;

    public override string LocalName
    {
      get
      {
        return "dataBar";
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
        return 11399;
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
        return DataBar.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataBar.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "minLength")]
    public UInt32Value MinLength
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxLength")]
    public UInt32Value MaxLength
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showValue")]
    public BooleanValue ShowValue
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public DataBar()
    {
    }

    public DataBar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataBar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataBar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "cfvo" == name)
        return (OpenXmlElement) new ConditionalFormatValueObject();
      if (22 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "minLength" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "maxLength" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "showValue" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataBar>(deep);
    }
  }
}
