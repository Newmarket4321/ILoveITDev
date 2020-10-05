// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.Shape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (AdjustList))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Shape : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "rot",
      "type",
      "blip",
      "zOrderOff",
      "hideGeom",
      "lkTxEntry",
      "blipPhldr"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 0,
      (byte) 0,
      (byte) 19,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "adjLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 14,
      (byte) 14
    };
    private const string tagName = "shape";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10713;

    public override string LocalName
    {
      get
      {
        return "shape";
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
        return 10713;
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
        return Shape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rot")]
    public DoubleValue Rotation
    {
      get
      {
        return (DoubleValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "type")]
    public StringValue Type
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

    [SchemaAttr(19, "blip")]
    public StringValue Blip
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

    [SchemaAttr(0, "zOrderOff")]
    public Int32Value ZOrderOffset
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hideGeom")]
    public BooleanValue HideGeometry
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lkTxEntry")]
    public BooleanValue LockedText
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "blipPhldr")]
    public BooleanValue BlipPlaceholder
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    public Shape()
    {
    }

    public Shape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Shape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Shape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "adjLst" == name)
        return (OpenXmlElement) new AdjustList();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Shape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Shape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AdjustList AdjustList
    {
      get
      {
        return this.GetElement<AdjustList>(0);
      }
      set
      {
        this.SetElement<AdjustList>(0, value);
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
      if ((int) namespaceId == 0 && "rot" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "blip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "zOrderOff" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "hideGeom" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "lkTxEntry" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "blipPhldr" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shape>(deep);
    }
  }
}
