// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BodyProperties))]
  [ChildElementInfo(typeof (ListStyle))]
  [ChildElementInfo(typeof (ShapeStyle))]
  [ChildElementInfo(typeof (ExtensionList))]
  public abstract class DefaultShapeDefinitionType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "spPr",
      "bodyPr",
      "lstStyle",
      "style",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (10 == (int) namespaceId && "bodyPr" == name)
        return (OpenXmlElement) new BodyProperties();
      if (10 == (int) namespaceId && "lstStyle" == name)
        return (OpenXmlElement) new ListStyle();
      if (10 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DefaultShapeDefinitionType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DefaultShapeDefinitionType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(0);
      }
      set
      {
        this.SetElement<ShapeProperties>(0, value);
      }
    }

    public BodyProperties BodyProperties
    {
      get
      {
        return this.GetElement<BodyProperties>(1);
      }
      set
      {
        this.SetElement<BodyProperties>(1, value);
      }
    }

    public ListStyle ListStyle
    {
      get
      {
        return this.GetElement<ListStyle>(2);
      }
      set
      {
        this.SetElement<ListStyle>(2, value);
      }
    }

    public ShapeStyle ShapeStyle
    {
      get
      {
        return this.GetElement<ShapeStyle>(3);
      }
      set
      {
        this.SetElement<ShapeStyle>(3, value);
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

    protected DefaultShapeDefinitionType()
    {
    }

    protected DefaultShapeDefinitionType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected DefaultShapeDefinitionType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected DefaultShapeDefinitionType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
