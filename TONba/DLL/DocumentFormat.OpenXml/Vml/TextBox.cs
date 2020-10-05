// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.TextBox
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [ChildElementInfo(typeof (TextBoxContent))]
  [GeneratedCode("DomGen", "2.0")]
  public class TextBox : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "id",
      "style",
      "inset",
      "singleclick"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27
    };
    private const string tagName = "textbox";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12583;

    public override string LocalName
    {
      get
      {
        return "textbox";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12583;
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
        return TextBox.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextBox.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "style")]
    public StringValue Style
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "inset")]
    public StringValue Inset
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "singleclick")]
    public TrueFalseValue SingleClick
    {
      get
      {
        return (TrueFalseValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public TextBox()
    {
    }

    public TextBox(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextBox(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextBox(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "txbxContent" == name)
        return (OpenXmlElement) new TextBoxContent();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "style" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "inset" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "singleclick" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextBox>(deep);
    }
  }
}
