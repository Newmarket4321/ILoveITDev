// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeader
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ColorTransformCategories))]
  [ChildElementInfo(typeof (ColorTransformDescription))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColorDefinitionTitle))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class ColorsDefinitionHeader : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "uniqueId",
      "minVer",
      "resId"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "colorsDefHdr";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10683;

    public override string LocalName
    {
      get
      {
        return "colorsDefHdr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10683;
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
        return ColorsDefinitionHeader.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorsDefinitionHeader.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
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

    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
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

    [SchemaAttr(0, "resId")]
    public Int32Value ResourceId
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

    public ColorsDefinitionHeader()
    {
    }

    public ColorsDefinitionHeader(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorsDefinitionHeader(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorsDefinitionHeader(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new ColorDefinitionTitle();
      if (14 == (int) namespaceId && "desc" == name)
        return (OpenXmlElement) new ColorTransformDescription();
      if (14 == (int) namespaceId && "catLst" == name)
        return (OpenXmlElement) new ColorTransformCategories();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniqueId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "minVer" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "resId" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorsDefinitionHeader>(deep);
    }
  }
}
