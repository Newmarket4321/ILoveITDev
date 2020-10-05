// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (EffectColorList))]
  [ChildElementInfo(typeof (TextLineColorList))]
  [ChildElementInfo(typeof (TextFillColorList))]
  [ChildElementInfo(typeof (TextEffectColorList))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LineColorList))]
  [ChildElementInfo(typeof (FillColorList))]
  public class ColorTransformStyleLabel : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[7]
    {
      "fillClrLst",
      "linClrLst",
      "effectClrLst",
      "txLinClrLst",
      "txFillClrLst",
      "txEffectClrLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "styleLbl";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10704;

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
        return 10704;
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
        return ColorTransformStyleLabel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorTransformStyleLabel.attributeNamespaceIds;
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

    public ColorTransformStyleLabel()
    {
    }

    public ColorTransformStyleLabel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorTransformStyleLabel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorTransformStyleLabel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "fillClrLst" == name)
        return (OpenXmlElement) new FillColorList();
      if (14 == (int) namespaceId && "linClrLst" == name)
        return (OpenXmlElement) new LineColorList();
      if (14 == (int) namespaceId && "effectClrLst" == name)
        return (OpenXmlElement) new EffectColorList();
      if (14 == (int) namespaceId && "txLinClrLst" == name)
        return (OpenXmlElement) new TextLineColorList();
      if (14 == (int) namespaceId && "txFillClrLst" == name)
        return (OpenXmlElement) new TextFillColorList();
      if (14 == (int) namespaceId && "txEffectClrLst" == name)
        return (OpenXmlElement) new TextEffectColorList();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ColorTransformStyleLabel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ColorTransformStyleLabel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FillColorList FillColorList
    {
      get
      {
        return this.GetElement<FillColorList>(0);
      }
      set
      {
        this.SetElement<FillColorList>(0, value);
      }
    }

    public LineColorList LineColorList
    {
      get
      {
        return this.GetElement<LineColorList>(1);
      }
      set
      {
        this.SetElement<LineColorList>(1, value);
      }
    }

    public EffectColorList EffectColorList
    {
      get
      {
        return this.GetElement<EffectColorList>(2);
      }
      set
      {
        this.SetElement<EffectColorList>(2, value);
      }
    }

    public TextLineColorList TextLineColorList
    {
      get
      {
        return this.GetElement<TextLineColorList>(3);
      }
      set
      {
        this.SetElement<TextLineColorList>(3, value);
      }
    }

    public TextFillColorList TextFillColorList
    {
      get
      {
        return this.GetElement<TextFillColorList>(4);
      }
      set
      {
        this.SetElement<TextFillColorList>(4, value);
      }
    }

    public TextEffectColorList TextEffectColorList
    {
      get
      {
        return this.GetElement<TextEffectColorList>(5);
      }
      set
      {
        this.SetElement<TextEffectColorList>(5, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(6);
      }
      set
      {
        this.SetElement<ExtensionList>(6, value);
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
      return (OpenXmlElement) this.CloneImp<ColorTransformStyleLabel>(deep);
    }
  }
}
