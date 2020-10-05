// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ByColor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (RgbColor))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HslColor))]
  public class ByColor : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "rgb",
      "hsl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "by";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12300;

    public override string LocalName
    {
      get
      {
        return "by";
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
        return 12300;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ByColor()
    {
    }

    public ByColor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ByColor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ByColor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "rgb" == name)
        return (OpenXmlElement) new RgbColor();
      if (24 == (int) namespaceId && "hsl" == name)
        return (OpenXmlElement) new HslColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ByColor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ByColor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public RgbColor RgbColor
    {
      get
      {
        return this.GetElement<RgbColor>(0);
      }
      set
      {
        this.SetElement<RgbColor>(0, value);
      }
    }

    public HslColor HslColor
    {
      get
      {
        return this.GetElement<HslColor>(1);
      }
      set
      {
        this.SetElement<HslColor>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ByColor>(deep);
    }
  }
}
