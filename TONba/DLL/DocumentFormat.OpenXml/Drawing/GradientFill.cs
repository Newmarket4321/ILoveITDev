// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.GradientFill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (PathGradientFill))]
  [ChildElementInfo(typeof (GradientStopList))]
  [ChildElementInfo(typeof (LinearGradientFill))]
  [ChildElementInfo(typeof (TileRectangle))]
  [GeneratedCode("DomGen", "2.0")]
  public class GradientFill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "flip",
      "rotWithShape"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[4]
    {
      "gsLst",
      "lin",
      "path",
      "tileRect"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "gradFill";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10049;

    public override string LocalName
    {
      get
      {
        return "gradFill";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10049;
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
        return GradientFill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GradientFill.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "flip")]
    public EnumValue<TileFlipValues> Flip
    {
      get
      {
        return (EnumValue<TileFlipValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public GradientFill()
    {
    }

    public GradientFill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GradientFill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GradientFill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "gsLst" == name)
        return (OpenXmlElement) new GradientStopList();
      if (10 == (int) namespaceId && "lin" == name)
        return (OpenXmlElement) new LinearGradientFill();
      if (10 == (int) namespaceId && "path" == name)
        return (OpenXmlElement) new PathGradientFill();
      if (10 == (int) namespaceId && "tileRect" == name)
        return (OpenXmlElement) new TileRectangle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GradientFill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GradientFill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GradientStopList GradientStopList
    {
      get
      {
        return this.GetElement<GradientStopList>(0);
      }
      set
      {
        this.SetElement<GradientStopList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "flip" == name)
        return (OpenXmlSimpleType) new EnumValue<TileFlipValues>();
      if ((int) namespaceId == 0 && "rotWithShape" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GradientFill>(deep);
    }
  }
}
