// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Dimension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class Dimension : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "measure",
      "name",
      "uniqueName",
      "caption"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "dimension";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11181;

    public override string LocalName
    {
      get
      {
        return "dimension";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11181;
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
        return Dimension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Dimension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "measure")]
    public BooleanValue Measure
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
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

    [SchemaAttr(0, "caption")]
    public StringValue Caption
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
      if ((int) namespaceId == 0 && "measure" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Dimension>(deep);
    }
  }
}
