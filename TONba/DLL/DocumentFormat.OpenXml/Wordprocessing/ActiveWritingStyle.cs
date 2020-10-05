// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ActiveWritingStyle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "lang",
      "vendorID",
      "dllVersion",
      "nlCheck",
      "checkStyle",
      "appName"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "activeWritingStyle";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12124;

    public override string LocalName
    {
      get
      {
        return "activeWritingStyle";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12124;
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
        return ActiveWritingStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ActiveWritingStyle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "lang")]
    public StringValue Language
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

    [SchemaAttr(23, "vendorID")]
    public UInt16Value VendorID
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "dllVersion")]
    public Int32Value DllVersion
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "nlCheck")]
    public OnOffValue NaturalLanguageGrammarCheck
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "checkStyle")]
    public OnOffValue CheckStyle
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "appName")]
    public StringValue ApplicationName
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "lang" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "vendorID" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if (23 == (int) namespaceId && "dllVersion" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "nlCheck" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "checkStyle" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "appName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ActiveWritingStyle>(deep);
    }
  }
}
