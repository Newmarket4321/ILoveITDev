// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class EffectExtent : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "l",
      "t",
      "r",
      "b"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "effectExtent";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10769;

    public override string LocalName
    {
      get
      {
        return "effectExtent";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 16;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10769;
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
        return EffectExtent.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EffectExtent.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "l")]
    public Int64Value LeftEdge
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "t")]
    public Int64Value TopEdge
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "r")]
    public Int64Value RightEdge
    {
      get
      {
        return (Int64Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "b")]
    public Int64Value BottomEdge
    {
      get
      {
        return (Int64Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "l" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "b" == name)
        return (OpenXmlSimpleType) new Int64Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EffectExtent>(deep);
    }
  }
}
