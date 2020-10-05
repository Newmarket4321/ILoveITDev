// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.LongProperties.LongProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.LongProperties
{
  [GeneratedCode("DomGen", "2.0")]
  public class LongProperty : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "LongProp";
    private const byte tagNsId = 40;
    internal const int ElementTypeIdConst = 12712;

    public override string LocalName
    {
      get
      {
        return "LongProp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 40;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12712;
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
        return LongProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LongProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    public LongProperty()
    {
    }

    public LongProperty(string text)
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
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LongProperty>(deep);
    }
  }
}
