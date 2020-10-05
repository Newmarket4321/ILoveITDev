// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Word.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebVideoProperty : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "embeddedHtml",
      "h",
      "w"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "webVideoPr";
    private const byte tagNsId = 75;
    internal const int ElementTypeIdConst = 13437;

    public override string LocalName
    {
      get
      {
        return "webVideoPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 75;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13437;
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
        return WebVideoProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WebVideoProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "embeddedHtml")]
    public StringValue EmbeddedHtml
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

    [SchemaAttr(0, "h")]
    public UInt32Value Height
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

    [SchemaAttr(0, "w")]
    public UInt32Value Width
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "embeddedHtml" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "h" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "w" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebVideoProperty>(deep);
    }
  }
}
