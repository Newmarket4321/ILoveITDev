// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public class FixedCommandKeyboardCustomization : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "fciName",
      "fciIndex",
      "swArg"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "fci";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12612;

    public override string LocalName
    {
      get
      {
        return "fci";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12612;
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
        return FixedCommandKeyboardCustomization.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FixedCommandKeyboardCustomization.attributeNamespaceIds;
      }
    }

    [SchemaAttr(33, "fciName")]
    public StringValue CommandName
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

    [SchemaAttr(33, "fciIndex")]
    public HexBinaryValue CommandIndex
    {
      get
      {
        return (HexBinaryValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "swArg")]
    public HexBinaryValue Argument
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "fciName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && "fciIndex" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "swArg" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FixedCommandKeyboardCustomization>(deep);
    }
  }
}
