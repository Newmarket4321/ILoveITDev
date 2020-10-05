// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ListItem))]
  [GeneratedCode("DomGen", "2.0")]
  public class SdtContentComboBox : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "lastValue"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "comboBox";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12092;

    public override string LocalName
    {
      get
      {
        return "comboBox";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12092;
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
        return SdtContentComboBox.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SdtContentComboBox.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "lastValue")]
    public StringValue LastValue
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public SdtContentComboBox()
    {
    }

    public SdtContentComboBox(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtContentComboBox(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtContentComboBox(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "listItem" == name)
        return (OpenXmlElement) new ListItem();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "lastValue" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtContentComboBox>(deep);
    }
  }
}
