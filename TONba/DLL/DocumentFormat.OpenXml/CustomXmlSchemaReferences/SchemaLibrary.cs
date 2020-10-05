// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.CustomXmlSchemaReferences
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Schema))]
  public class SchemaLibrary : OpenXmlCompositeElement
  {
    private const string tagName = "schemaLibrary";
    private const byte tagNsId = 25;
    internal const int ElementTypeIdConst = 12468;

    public override string LocalName
    {
      get
      {
        return "schemaLibrary";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 25;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12468;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SchemaLibrary()
    {
    }

    public SchemaLibrary(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SchemaLibrary(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SchemaLibrary(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (25 == (int) namespaceId && "schema" == name)
        return (OpenXmlElement) new Schema();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SchemaLibrary>(deep);
    }
  }
}
