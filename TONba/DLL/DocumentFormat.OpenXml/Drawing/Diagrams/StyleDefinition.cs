// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StyleDisplayCategories))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (StyleLabelDescription))]
  [ChildElementInfo(typeof (StyleDefinitionTitle))]
  [ChildElementInfo(typeof (Scene3D))]
  [ChildElementInfo(typeof (StyleLabel))]
  public class StyleDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "uniqueId",
      "minVer"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "styleDef";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10690;

    public override string LocalName
    {
      get
      {
        return "styleDef";
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
        return 10690;
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
        return StyleDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StyleDefinition.attributeNamespaceIds;
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

    internal StyleDefinition(DiagramStylePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DiagramStylePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DiagramStylePart DiagramStylePart
    {
      get
      {
        return this.OpenXmlPart as DiagramStylePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public StyleDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StyleDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StyleDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public StyleDefinition()
    {
    }

    public void Save(DiagramStylePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new StyleDefinitionTitle();
      if (14 == (int) namespaceId && "desc" == name)
        return (OpenXmlElement) new StyleLabelDescription();
      if (14 == (int) namespaceId && "catLst" == name)
        return (OpenXmlElement) new StyleDisplayCategories();
      if (14 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3D();
      if (14 == (int) namespaceId && "styleLbl" == name)
        return (OpenXmlElement) new StyleLabel();
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
      return (OpenXmlElement) this.CloneImp<StyleDefinition>(deep);
    }
  }
}
