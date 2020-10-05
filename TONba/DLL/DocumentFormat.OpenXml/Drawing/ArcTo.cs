// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ArcTo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ArcTo : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "wR",
      "hR",
      "stAng",
      "swAng"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "arcTo";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10222;

    public override string LocalName
    {
      get
      {
        return "arcTo";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10222;
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
        return ArcTo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ArcTo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "wR")]
    public StringValue WidthRadius
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

    [SchemaAttr(0, "hR")]
    public StringValue HeightRadius
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stAng")]
    public StringValue StartAngle
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "swAng")]
    public StringValue SwingAngle
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
      if ((int) namespaceId == 0 && "wR" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hR" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "stAng" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "swAng" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ArcTo>(deep);
    }
  }
}
