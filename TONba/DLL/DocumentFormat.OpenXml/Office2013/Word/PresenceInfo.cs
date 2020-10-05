// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.PresenceInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class PresenceInfo : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "providerId",
      "userId"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 69,
      (byte) 69
    };
    private const string tagName = "presenceInfo";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13350;

    public override string LocalName
    {
      get
      {
        return "presenceInfo";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13350;
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
        return PresenceInfo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PresenceInfo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(69, "providerId")]
    public StringValue ProviderId
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

    [SchemaAttr(69, "userId")]
    public StringValue UserId
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "providerId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (69 == (int) namespaceId && "userId" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresenceInfo>(deep);
    }
  }
}
