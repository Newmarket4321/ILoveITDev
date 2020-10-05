// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ModelRelationship), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class ModelRelationships : OpenXmlCompositeElement
  {
    private const string tagName = "modelRelationships";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13409;

    public override string LocalName
    {
      get
      {
        return "modelRelationships";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13409;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public ModelRelationships()
    {
    }

    public ModelRelationships(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ModelRelationships(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ModelRelationships(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "modelRelationship" == name)
        return (OpenXmlElement) new ModelRelationship();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ModelRelationships>(deep);
    }
  }
}
