// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.SphereCoordinates
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class SphereCoordinates : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "lat",
      "lon",
      "rev"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "rot";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12946;

    public override string LocalName
    {
      get
      {
        return "rot";
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
        return 12946;
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
        return SphereCoordinates.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SphereCoordinates.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "lat")]
    public Int32Value Lattitude
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

    [SchemaAttr(52, "lon")]
    public Int32Value Longitude
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

    [SchemaAttr(52, "rev")]
    public Int32Value Revolution
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "lat" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "lon" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "rev" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SphereCoordinates>(deep);
    }
  }
}
