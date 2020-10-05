// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.ActiveArea
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  public class ActiveArea : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "size",
      "height",
      "width",
      "units"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "activeArea";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12725;

    public override string LocalName
    {
      get
      {
        return "activeArea";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12725;
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
        return ActiveArea.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ActiveArea.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "size")]
    public StringValue Size
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

    [SchemaAttr(0, "height")]
    public DecimalValue Height
    {
      get
      {
        return (DecimalValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "width")]
    public DecimalValue Width
    {
      get
      {
        return (DecimalValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "units")]
    public StringValue Units
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
      if ((int) namespaceId == 0 && "size" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "height" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "width" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "units" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ActiveArea>(deep);
    }
  }
}
