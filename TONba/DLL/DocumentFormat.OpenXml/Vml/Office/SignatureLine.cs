// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.SignatureLine
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class SignatureLine : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[13]
    {
      "ext",
      "issignatureline",
      "id",
      "provid",
      "signinginstructionsset",
      "allowcomments",
      "showsigndate",
      "suggestedsigner",
      "suggestedsigner2",
      "suggestedsigneremail",
      "signinginstructions",
      "addlxml",
      "sigprovurl"
    };
    private static byte[] attributeNamespaceIds = new byte[13]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "signatureline";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12472;

    public override string LocalName
    {
      get
      {
        return "signatureline";
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
        return 12472;
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
        return SignatureLine.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SignatureLine.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "issignatureline")]
    public TrueFalseValue IsSignatureLine
    {
      get
      {
        return (TrueFalseValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "provid")]
    public StringValue ProviderId
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

    [SchemaAttr(0, "signinginstructionsset")]
    public TrueFalseValue SigningInstructionsSet
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

    [SchemaAttr(0, "allowcomments")]
    public TrueFalseValue AllowComments
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

    [SchemaAttr(0, "showsigndate")]
    public TrueFalseValue ShowSignDate
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

    [SchemaAttr(27, "suggestedsigner")]
    public StringValue SuggestedSigner
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

    [SchemaAttr(27, "suggestedsigner2")]
    public StringValue SuggestedSigner2
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "suggestedsigneremail")]
    public StringValue SuggestedSignerEmail
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "signinginstructions")]
    public StringValue SigningInstructions
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "addlxml")]
    public StringValue AdditionalXml
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sigprovurl")]
    public StringValue SignatureProviderUrl
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "issignatureline" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "provid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "signinginstructionsset" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "allowcomments" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "showsigndate" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "suggestedsigner" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "suggestedsigner2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "suggestedsigneremail" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "signinginstructions" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "addlxml" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sigprovurl" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SignatureLine>(deep);
    }
  }
}
