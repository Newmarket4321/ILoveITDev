// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class LatentStyleExceptionInfo : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "name",
      "locked",
      "uiPriority",
      "semiHidden",
      "unhideWhenUsed",
      "qFormat"
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
    private const string tagName = "lsdException";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11959;

    public override string LocalName
    {
      get
      {
        return "lsdException";
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
        return 11959;
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
        return LatentStyleExceptionInfo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LatentStyleExceptionInfo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "name")]
    public StringValue Name
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

    [SchemaAttr(23, "locked")]
    public OnOffValue Locked
    {
      get
      {
        return (OnOffValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "uiPriority")]
    public Int32Value UiPriority
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

    [SchemaAttr(23, "semiHidden")]
    public OnOffValue SemiHidden
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

    [SchemaAttr(23, "unhideWhenUsed")]
    public OnOffValue UnhideWhenUsed
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

    [SchemaAttr(23, "qFormat")]
    public OnOffValue PrimaryStyle
    {
      get
      {
        return (OnOffValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "locked" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "uiPriority" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "semiHidden" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "unhideWhenUsed" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "qFormat" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LatentStyleExceptionInfo>(deep);
    }
  }
}
