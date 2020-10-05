// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ExtensionListWithModification
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Extension))]
  public class ExtensionListWithModification : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "mod"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "extLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12299;

    public override string LocalName
    {
      get
      {
        return "extLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12299;
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
        return ExtensionListWithModification.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ExtensionListWithModification.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "mod")]
    public BooleanValue Modify
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public ExtensionListWithModification()
    {
    }

    public ExtensionListWithModification(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExtensionListWithModification(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExtensionListWithModification(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new Extension();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "mod" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExtensionListWithModification>(deep);
    }
  }
}
