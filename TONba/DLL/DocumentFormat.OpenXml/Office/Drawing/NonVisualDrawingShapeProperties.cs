// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Drawing
{
  [ChildElementInfo(typeof (ShapeLocks))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  public class NonVisualDrawingShapeProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "txBox"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "spLocks",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvSpPr";
    private const byte tagNsId = 56;
    internal const int ElementTypeIdConst = 13086;

    public override string LocalName
    {
      get
      {
        return "cNvSpPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 56;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13086;
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
        return NonVisualDrawingShapeProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NonVisualDrawingShapeProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "txBox")]
    public BooleanValue TextBox
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

    public NonVisualDrawingShapeProperties()
    {
    }

    public NonVisualDrawingShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualDrawingShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualDrawingShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "spLocks" == name)
        return (OpenXmlElement) new ShapeLocks();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualDrawingShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualDrawingShapeProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShapeLocks ShapeLocks
    {
      get
      {
        return this.GetElement<ShapeLocks>(0);
      }
      set
      {
        this.SetElement<ShapeLocks>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "txBox" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualDrawingShapeProperties>(deep);
    }
  }
}
