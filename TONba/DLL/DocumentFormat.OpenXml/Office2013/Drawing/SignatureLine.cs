// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SignatureLine : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "isSignatureLine",
      "id",
      "provId",
      "signingInstructionsSet",
      "allowComments",
      "showSignDate",
      "suggestedSigner",
      "suggestedSigner2",
      "suggestedSignerEmail",
      "signingInstructions",
      "addlXml",
      "sigProvUrl"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private const string tagName = "signatureLine";
    private const byte tagNsId = 67;
    internal const int ElementTypeIdConst = 13324;

    public override string LocalName
    {
      get
      {
        return "signatureLine";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 67;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13324;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
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

    [SchemaAttr(0, "isSignatureLine")]
    public BooleanValue IsSignatureLine
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

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "provId")]
    public StringValue ProviderId
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

    [SchemaAttr(0, "signingInstructionsSet")]
    public BooleanValue SigningInstructionsSet
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "allowComments")]
    public BooleanValue AllowComments
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showSignDate")]
    public BooleanValue ShowSignDate
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "suggestedSigner")]
    public StringValue SuggestedSigner
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "suggestedSigner2")]
    public StringValue SuggestedSigner2
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

    [SchemaAttr(0, "suggestedSignerEmail")]
    public StringValue SuggestedSignerEmail
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

    [SchemaAttr(0, "signingInstructions")]
    public StringValue SigningInstructions
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

    [SchemaAttr(0, "addlXml")]
    public StringValue AdditionalXml
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

    [SchemaAttr(0, "sigProvUrl")]
    public StringValue SignatureProviderUrl
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "isSignatureLine" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "provId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "signingInstructionsSet" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allowComments" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showSignDate" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "suggestedSigner" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "suggestedSigner2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "suggestedSignerEmail" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "signingInstructions" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "addlXml" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sigProvUrl" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SignatureLine>(deep);
    }
  }
}
