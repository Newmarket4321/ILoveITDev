// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.ExcelAc.AbsolutePath
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.ExcelAc
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class AbsolutePath : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "url"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "absPath";
    private const byte tagNsId = 74;
    internal const int ElementTypeIdConst = 13436;

    public override string LocalName
    {
      get
      {
        return "absPath";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 74;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13436;
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
        return AbsolutePath.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AbsolutePath.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "url")]
    public StringValue Url
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
      if ((int) namespaceId == 0 && "url" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AbsolutePath>(deep);
    }
  }
}
