// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ColorChange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ColorFrom))]
  [ChildElementInfo(typeof (ColorTo))]
  [GeneratedCode("DomGen", "2.0")]
  public class ColorChange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "useA"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "clrFrom",
      "clrTo"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "clrChange";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10066;

    public override string LocalName
    {
      get
      {
        return "clrChange";
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
        return 10066;
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
        return ColorChange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorChange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "useA")]
    public BooleanValue UseAlpha
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

    public ColorChange()
    {
    }

    public ColorChange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorChange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorChange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "clrFrom" == name)
        return (OpenXmlElement) new ColorFrom();
      if (10 == (int) namespaceId && "clrTo" == name)
        return (OpenXmlElement) new ColorTo();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ColorChange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ColorChange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ColorFrom ColorFrom
    {
      get
      {
        return this.GetElement<ColorFrom>(0);
      }
      set
      {
        this.SetElement<ColorFrom>(0, value);
      }
    }

    public ColorTo ColorTo
    {
      get
      {
        return this.GetElement<ColorTo>(1);
      }
      set
      {
        this.SetElement<ColorTo>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "useA" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorChange>(deep);
    }
  }
}
