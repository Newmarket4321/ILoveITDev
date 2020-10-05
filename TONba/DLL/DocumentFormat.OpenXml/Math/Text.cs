// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Text
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  public class Text : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "space"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 1
    };
    private const string tagName = "t";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10935;

    public override string LocalName
    {
      get
      {
        return "t";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10935;
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
        return Text.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Text.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "space")]
    public EnumValue<SpaceProcessingModeValues> Space
    {
      get
      {
        return (EnumValue<SpaceProcessingModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Text()
    {
    }

    public Text(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "space" == name)
        return (OpenXmlSimpleType) new EnumValue<SpaceProcessingModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Text>(deep);
    }
  }
}
