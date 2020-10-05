// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Shape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  public class Shape : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 21
    };
    private const string tagName = "shp";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10959;

    public override string LocalName
    {
      get
      {
        return "shp";
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
        return 10959;
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
        return Shape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(21, "val")]
    public EnumValue<ShapeDelimiterValues> Val
    {
      get
      {
        return (EnumValue<ShapeDelimiterValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<ShapeDelimiterValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shape>(deep);
    }
  }
}
