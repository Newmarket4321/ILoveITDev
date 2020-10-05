// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.CustomXmlDataProperties
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SchemaReference))]
  public class SchemaReferences : OpenXmlCompositeElement
  {
    private const string tagName = "schemaRefs";
    private const byte tagNsId = 20;
    internal const int ElementTypeIdConst = 10902;

    public override string LocalName
    {
      get
      {
        return "schemaRefs";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 20;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10902;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SchemaReferences()
    {
    }

    public SchemaReferences(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SchemaReferences(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SchemaReferences(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (20 == (int) namespaceId && "schemaRef" == name)
        return (OpenXmlElement) new SchemaReference();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SchemaReferences>(deep);
    }
  }
}
