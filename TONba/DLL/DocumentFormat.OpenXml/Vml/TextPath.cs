// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.TextPath
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  public class TextPath : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "id",
      "style",
      "on",
      "fitshape",
      "fitpath",
      "trim",
      "xscale",
      "string"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "textpath";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12584;

    public override string LocalName
    {
      get
      {
        return "textpath";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12584;
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
        return TextPath.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextPath.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "style")]
    public StringValue Style
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

    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
      get
      {
        return (TrueFalseValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fitshape")]
    public TrueFalseValue FitShape
    {
      get
      {
        return (TrueFalseValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fitpath")]
    public TrueFalseValue FitPath
    {
      get
      {
        return (TrueFalseValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "trim")]
    public TrueFalseValue Trim
    {
      get
      {
        return (TrueFalseValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "xscale")]
    public TrueFalseValue XScale
    {
      get
      {
        return (TrueFalseValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "string")]
    public StringValue String
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "style" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "on" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "fitshape" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "fitpath" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "trim" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "xscale" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "string" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextPath>(deep);
    }
  }
}
