// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (Stretch))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Blip))]
  [ChildElementInfo(typeof (SourceRectangle))]
  [ChildElementInfo(typeof (Tile))]
  public class BlipFill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "rotWithShape"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[4]
    {
      "blip",
      "srcRect",
      "tile",
      "stretch"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "blipFill";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10802;

    public override string LocalName
    {
      get
      {
        return "blipFill";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10802;
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
        return BlipFill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BlipFill.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
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

    public BlipFill()
    {
    }

    public BlipFill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BlipFill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BlipFill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "blip" == name)
        return (OpenXmlElement) new Blip();
      if (10 == (int) namespaceId && "srcRect" == name)
        return (OpenXmlElement) new SourceRectangle();
      if (10 == (int) namespaceId && "tile" == name)
        return (OpenXmlElement) new Tile();
      if (10 == (int) namespaceId && "stretch" == name)
        return (OpenXmlElement) new Stretch();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BlipFill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BlipFill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Blip Blip
    {
      get
      {
        return this.GetElement<Blip>(0);
      }
      set
      {
        this.SetElement<Blip>(0, value);
      }
    }

    public SourceRectangle SourceRectangle
    {
      get
      {
        return this.GetElement<SourceRectangle>(1);
      }
      set
      {
        this.SetElement<SourceRectangle>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rotWithShape" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BlipFill>(deep);
    }
  }
}
