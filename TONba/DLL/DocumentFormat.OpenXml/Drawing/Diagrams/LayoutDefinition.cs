// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LayoutNode))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Title))]
  [ChildElementInfo(typeof (Description))]
  [ChildElementInfo(typeof (CategoryList))]
  [ChildElementInfo(typeof (SampleData))]
  [ChildElementInfo(typeof (StyleData))]
  [ChildElementInfo(typeof (ColorData))]
  public class LayoutDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "uniqueId",
      "minVer",
      "defStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "layoutDef";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10686;

    public override string LocalName
    {
      get
      {
        return "layoutDef";
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
        return 10686;
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
        return LayoutDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LayoutDefinition.attributeNamespaceIds;
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

    [SchemaAttr(0, "defStyle")]
    public StringValue DefaultStyle
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal LayoutDefinition(DiagramLayoutDefinitionPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DiagramLayoutDefinitionPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DiagramLayoutDefinitionPart DiagramLayoutDefinitionPart
    {
      get
      {
        return this.OpenXmlPart as DiagramLayoutDefinitionPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public LayoutDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LayoutDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LayoutDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public LayoutDefinition()
    {
    }

    public void Save(DiagramLayoutDefinitionPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new Title();
      if (14 == (int) namespaceId && "desc" == name)
        return (OpenXmlElement) new Description();
      if (14 == (int) namespaceId && "catLst" == name)
        return (OpenXmlElement) new CategoryList();
      if (14 == (int) namespaceId && "sampData" == name)
        return (OpenXmlElement) new SampleData();
      if (14 == (int) namespaceId && "styleData" == name)
        return (OpenXmlElement) new StyleData();
      if (14 == (int) namespaceId && "clrData" == name)
        return (OpenXmlElement) new ColorData();
      if (14 == (int) namespaceId && "layoutNode" == name)
        return (OpenXmlElement) new LayoutNode();
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
      if ((int) namespaceId == 0 && "defStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LayoutDefinition>(deep);
    }
  }
}
