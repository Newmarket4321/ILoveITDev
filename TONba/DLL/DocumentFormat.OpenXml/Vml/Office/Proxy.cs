// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Proxy
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class Proxy : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "start",
      "end",
      "idref",
      "connectloc"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "proxy";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12498;

    public override string LocalName
    {
      get
      {
        return "proxy";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12498;
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
        return Proxy.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Proxy.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "start")]
    public TrueFalseBlankValue Start
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "end")]
    public TrueFalseBlankValue End
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "idref")]
    public StringValue ShapeReference
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

    [SchemaAttr(0, "connectloc")]
    public Int32Value ConnectionLocation
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
      if ((int) namespaceId == 0 && "start" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if ((int) namespaceId == 0 && "end" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if ((int) namespaceId == 0 && "idref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "connectloc" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Proxy>(deep);
    }
  }
}
