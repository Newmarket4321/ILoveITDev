// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
  [GeneratedCode("DomGen", "2.0")]
  public class SharedComPicture : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 19
    };
    private const string tagName = "picture";
    private const byte tagNsId = 35;
    internal const int ElementTypeIdConst = 12691;

    public override string LocalName
    {
      get
      {
        return "picture";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 35;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12691;
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
        return SharedComPicture.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SharedComPicture.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SharedComPicture>(deep);
    }
  }
}
