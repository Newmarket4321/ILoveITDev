// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingShape
{
  [ChildElementInfo(typeof (ShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualDrawingShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualConnectorProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShapeStyle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextBoxInfo2), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LinkedTextBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextBodyProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class WordprocessingShape : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "normalEastAsianFlow"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[9]
    {
      "cNvPr",
      "cNvSpPr",
      "cNvCnPr",
      "spPr",
      "style",
      "extLst",
      "txbx",
      "linkedTxbx",
      "bodyPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61,
      (byte) 61
    };
    private const string tagName = "wsp";
    private const byte tagNsId = 61;
    internal const int ElementTypeIdConst = 13196;

    public override string LocalName
    {
      get
      {
        return "wsp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 61;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13196;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return WordprocessingShape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WordprocessingShape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "normalEastAsianFlow")]
    public BooleanValue NormalEastAsianFlow
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

    public WordprocessingShape()
    {
    }

    public WordprocessingShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WordprocessingShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WordprocessingShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (61 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (61 == (int) namespaceId && "cNvSpPr" == name)
        return (OpenXmlElement) new NonVisualDrawingShapeProperties();
      if (61 == (int) namespaceId && "cNvCnPr" == name)
        return (OpenXmlElement) new NonVisualConnectorProperties();
      if (61 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (61 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      if (61 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      if (61 == (int) namespaceId && "txbx" == name)
        return (OpenXmlElement) new TextBoxInfo2();
      if (61 == (int) namespaceId && "linkedTxbx" == name)
        return (OpenXmlElement) new LinkedTextBox();
      if (61 == (int) namespaceId && "bodyPr" == name)
        return (OpenXmlElement) new TextBodyProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WordprocessingShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WordprocessingShape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualDrawingProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualDrawingProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "normalEastAsianFlow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WordprocessingShape>(deep);
    }
  }
}
