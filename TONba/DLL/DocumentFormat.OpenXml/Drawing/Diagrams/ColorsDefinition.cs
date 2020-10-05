// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ColorTransformDescription))]
  [ChildElementInfo(typeof (ColorTransformCategories))]
  [ChildElementInfo(typeof (ColorDefinitionTitle))]
  [ChildElementInfo(typeof (ColorTransformStyleLabel))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class ColorsDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "uniqueId",
      "minVer"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "colorsDef";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10682;

    public override string LocalName
    {
      get
      {
        return "colorsDef";
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
        return 10682;
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
        return ColorsDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorsDefinition.attributeNamespaceIds;
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

    internal ColorsDefinition(DiagramColorsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DiagramColorsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DiagramColorsPart DiagramColorsPart
    {
      get
      {
        return this.OpenXmlPart as DiagramColorsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ColorsDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorsDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorsDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public ColorsDefinition()
    {
    }

    public void Save(DiagramColorsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new ColorDefinitionTitle();
      if (14 == (int) namespaceId && "desc" == name)
        return (OpenXmlElement) new ColorTransformDescription();
      if (14 == (int) namespaceId && "catLst" == name)
        return (OpenXmlElement) new ColorTransformCategories();
      if (14 == (int) namespaceId && "styleLbl" == name)
        return (OpenXmlElement) new ColorTransformStyleLabel();
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
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorsDefinition>(deep);
    }
  }
}
