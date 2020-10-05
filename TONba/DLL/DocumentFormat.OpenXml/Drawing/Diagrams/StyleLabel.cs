// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Style))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Scene3D))]
  [ChildElementInfo(typeof (Shape3D))]
  [ChildElementInfo(typeof (TextProperties))]
  public class StyleLabel : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[5]
    {
      "scene3d",
      "sp3d",
      "txPr",
      "style",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "styleLbl";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10749;

    public override string LocalName
    {
      get
      {
        return "styleLbl";
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
        return 10749;
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
        return StyleLabel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StyleLabel.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    public StyleLabel()
    {
    }

    public StyleLabel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StyleLabel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StyleLabel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3D();
      if (14 == (int) namespaceId && "sp3d" == name)
        return (OpenXmlElement) new Shape3D();
      if (14 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (14 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new Style();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StyleLabel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StyleLabel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Scene3D Scene3D
    {
      get
      {
        return this.GetElement<Scene3D>(0);
      }
      set
      {
        this.SetElement<Scene3D>(0, value);
      }
    }

    public Shape3D Shape3D
    {
      get
      {
        return this.GetElement<Shape3D>(1);
      }
      set
      {
        this.SetElement<Shape3D>(1, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(2);
      }
      set
      {
        this.SetElement<TextProperties>(2, value);
      }
    }

    public Style Style
    {
      get
      {
        return this.GetElement<Style>(3);
      }
      set
      {
        this.SetElement<Style>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StyleLabel>(deep);
    }
  }
}
