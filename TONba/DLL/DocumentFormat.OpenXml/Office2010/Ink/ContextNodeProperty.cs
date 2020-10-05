// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Ink.ContextNodeProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Ink
{
  [GeneratedCode("DomGen", "2.0")]
  public class ContextNodeProperty : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "type"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "property";
    private const byte tagNsId = 45;
    internal const int ElementTypeIdConst = 12759;

    public override string LocalName
    {
      get
      {
        return "property";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 45;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12759;
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
        return ContextNodeProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContextNodeProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public StringValue Type
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

    public ContextNodeProperty()
    {
    }

    public ContextNodeProperty(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      HexBinaryValue hexBinaryValue = new HexBinaryValue();
      hexBinaryValue.InnerText = text;
      return (OpenXmlSimpleType) hexBinaryValue;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContextNodeProperty>(deep);
    }
  }
}
