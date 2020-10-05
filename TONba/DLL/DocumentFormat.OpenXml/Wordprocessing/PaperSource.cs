// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PaperSource
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class PaperSource : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "first",
      "other"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "paperSrc";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11741;

    public override string LocalName
    {
      get
      {
        return "paperSrc";
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
        return 11741;
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
        return PaperSource.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PaperSource.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "first")]
    public UInt16Value First
    {
      get
      {
        return (UInt16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "other")]
    public UInt16Value Other
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "first" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if (23 == (int) namespaceId && "other" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PaperSource>(deep);
    }
  }
}
