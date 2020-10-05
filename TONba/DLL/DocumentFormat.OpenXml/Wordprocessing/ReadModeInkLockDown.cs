// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ReadModeInkLockDown : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "actualPg",
      "w",
      "h",
      "fontSz"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "readModeInkLockDown";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12194;

    public override string LocalName
    {
      get
      {
        return "readModeInkLockDown";
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
        return 12194;
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
        return ReadModeInkLockDown.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ReadModeInkLockDown.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "actualPg")]
    public OnOffValue UseActualPages
    {
      get
      {
        return (OnOffValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "w")]
    public UInt32Value Width
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

    [SchemaAttr(23, "h")]
    public UInt32Value Height
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

    [SchemaAttr(23, "fontSz")]
    public StringValue FontSize
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
      if (23 == (int) namespaceId && "actualPg" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "h" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "fontSz" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ReadModeInkLockDown>(deep);
    }
  }
}
