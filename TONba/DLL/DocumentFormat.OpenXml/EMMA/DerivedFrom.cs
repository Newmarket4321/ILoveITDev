// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.DerivedFrom
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  public class DerivedFrom : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "resource",
      "composite"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "derived-from";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12741;

    public override string LocalName
    {
      get
      {
        return "derived-from";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 44;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12741;
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
        return DerivedFrom.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DerivedFrom.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "resource")]
    public StringValue Resource
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

    [SchemaAttr(0, "composite")]
    public BooleanValue Composite
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
      if ((int) namespaceId == 0 && "resource" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "composite" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DerivedFrom>(deep);
    }
  }
}
