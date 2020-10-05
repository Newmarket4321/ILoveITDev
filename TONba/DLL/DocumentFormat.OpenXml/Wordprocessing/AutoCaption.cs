// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.AutoCaption
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class AutoCaption : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "name",
      "caption"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "autoCaption";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11979;

    public override string LocalName
    {
      get
      {
        return "autoCaption";
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
        return 11979;
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
        return AutoCaption.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AutoCaption.attributeNamespaceIds;
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

    [SchemaAttr(23, "caption")]
    public StringValue Caption
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
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AutoCaption>(deep);
    }
  }
}
