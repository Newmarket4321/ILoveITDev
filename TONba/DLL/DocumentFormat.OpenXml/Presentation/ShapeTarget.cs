// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ShapeTarget
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (BackgroundAnimation))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OleChartElement))]
  [ChildElementInfo(typeof (GraphicElement))]
  [ChildElementInfo(typeof (SubShape))]
  [ChildElementInfo(typeof (TextElement))]
  public class ShapeTarget : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "spid"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[5]
    {
      "bg",
      "subSp",
      "oleChartEl",
      "txEl",
      "graphicEl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "spTgt";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12386;

    public override string LocalName
    {
      get
      {
        return "spTgt";
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
        return 12386;
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
        return ShapeTarget.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShapeTarget.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
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

    public ShapeTarget()
    {
    }

    public ShapeTarget(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapeTarget(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapeTarget(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "bg" == name)
        return (OpenXmlElement) new BackgroundAnimation();
      if (24 == (int) namespaceId && "subSp" == name)
        return (OpenXmlElement) new SubShape();
      if (24 == (int) namespaceId && "oleChartEl" == name)
        return (OpenXmlElement) new OleChartElement();
      if (24 == (int) namespaceId && "txEl" == name)
        return (OpenXmlElement) new TextElement();
      if (24 == (int) namespaceId && "graphicEl" == name)
        return (OpenXmlElement) new GraphicElement();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ShapeTarget.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ShapeTarget.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public BackgroundAnimation BackgroundAnimation
    {
      get
      {
        return this.GetElement<BackgroundAnimation>(0);
      }
      set
      {
        this.SetElement<BackgroundAnimation>(0, value);
      }
    }

    public SubShape SubShape
    {
      get
      {
        return this.GetElement<SubShape>(1);
      }
      set
      {
        this.SetElement<SubShape>(1, value);
      }
    }

    public OleChartElement OleChartElement
    {
      get
      {
        return this.GetElement<OleChartElement>(2);
      }
      set
      {
        this.SetElement<OleChartElement>(2, value);
      }
    }

    public TextElement TextElement
    {
      get
      {
        return this.GetElement<TextElement>(3);
      }
      set
      {
        this.SetElement<TextElement>(3, value);
      }
    }

    public GraphicElement GraphicElement
    {
      get
      {
        return this.GetElement<GraphicElement>(4);
      }
      set
      {
        this.SetElement<GraphicElement>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "spid" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeTarget>(deep);
    }
  }
}
