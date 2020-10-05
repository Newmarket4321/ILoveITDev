// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Entry
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class Entry : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "new",
      "old"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "entry";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12491;

    public override string LocalName
    {
      get
      {
        return "entry";
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
        return 12491;
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
        return Entry.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Entry.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "new")]
    public Int32Value New
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "old")]
    public Int32Value Old
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "new" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "old" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Entry>(deep);
    }
  }
}
