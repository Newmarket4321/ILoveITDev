// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Blur
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Blur : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "rad",
      "grow"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "blur";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10065;

    public override string LocalName
    {
      get
      {
        return "blur";
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
        return 10065;
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
        return Blur.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Blur.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rad")]
    public Int64Value Radius
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

    [SchemaAttr(0, "grow")]
    public BooleanValue Grow
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rad" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "grow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Blur>(deep);
    }
  }
}
