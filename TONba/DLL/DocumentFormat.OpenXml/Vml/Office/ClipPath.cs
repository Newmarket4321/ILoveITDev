// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.ClipPath
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class ClipPath : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "v"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 27
    };
    private const string tagName = "clippath";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12486;

    public override string LocalName
    {
      get
      {
        return "clippath";
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
        return 12486;
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
        return ClipPath.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ClipPath.attributeNamespaceIds;
      }
    }

    [SchemaAttr(27, "v")]
    public StringValue Value
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
      if (27 == (int) namespaceId && "v" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ClipPath>(deep);
    }
  }
}
