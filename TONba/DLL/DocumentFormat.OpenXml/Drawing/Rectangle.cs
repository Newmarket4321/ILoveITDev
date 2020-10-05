// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Rectangle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Rectangle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "l",
      "t",
      "r",
      "b"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "rect";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10230;

    public override string LocalName
    {
      get
      {
        return "rect";
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
        return 10230;
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
        return Rectangle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Rectangle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "l")]
    public StringValue Left
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

    [SchemaAttr(0, "t")]
    public StringValue Top
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

    [SchemaAttr(0, "r")]
    public StringValue Right
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

    [SchemaAttr(0, "b")]
    public StringValue Bottom
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "l" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "b" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Rectangle>(deep);
    }
  }
}
