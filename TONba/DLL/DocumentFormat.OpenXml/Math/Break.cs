// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Break
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  public class Break : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "alnAt",
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "brk";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10932;

    public override string LocalName
    {
      get
      {
        return "brk";
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
        return 10932;
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
        return Break.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Break.attributeNamespaceIds;
      }
    }

    [SchemaAttr(21, "alnAt")]
    public IntegerValue AlignAt
    {
      get
      {
        return (IntegerValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
      get
      {
        return (IntegerValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "alnAt" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (21 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Break>(deep);
    }
  }
}
