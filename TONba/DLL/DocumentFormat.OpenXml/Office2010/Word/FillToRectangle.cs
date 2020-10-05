// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.FillToRectangle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class FillToRectangle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "l",
      "t",
      "r",
      "b"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "fillToRect";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12944;

    public override string LocalName
    {
      get
      {
        return "fillToRect";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12944;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return FillToRectangle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FillToRectangle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "l")]
    public Int32Value Left
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "t")]
    public Int32Value Top
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "r")]
    public Int32Value Right
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "b")]
    public Int32Value Bottom
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "l" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "t" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "r" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "b" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FillToRectangle>(deep);
    }
  }
}
