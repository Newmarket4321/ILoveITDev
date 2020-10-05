// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.CommentEx
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class CommentEx : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "paraId",
      "paraIdParent",
      "done"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 69,
      (byte) 69,
      (byte) 69
    };
    private const string tagName = "commentEx";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13348;

    public override string LocalName
    {
      get
      {
        return "commentEx";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13348;
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
        return CommentEx.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommentEx.attributeNamespaceIds;
      }
    }

    [SchemaAttr(69, "paraId")]
    public HexBinaryValue ParaId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(69, "paraIdParent")]
    public HexBinaryValue ParaIdParent
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

    [SchemaAttr(69, "done")]
    public OnOffValue Done
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "paraId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (69 == (int) namespaceId && "paraIdParent" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (69 == (int) namespaceId && "done" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommentEx>(deep);
    }
  }
}
