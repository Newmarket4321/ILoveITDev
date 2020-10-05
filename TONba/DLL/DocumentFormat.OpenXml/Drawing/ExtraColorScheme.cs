// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ExtraColorScheme
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColorScheme))]
  [ChildElementInfo(typeof (ColorMap))]
  public class ExtraColorScheme : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "clrScheme",
      "clrMap"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "extraClrScheme";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10245;

    public override string LocalName
    {
      get
      {
        return "extraClrScheme";
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
        return 10245;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ExtraColorScheme()
    {
    }

    public ExtraColorScheme(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExtraColorScheme(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExtraColorScheme(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "clrScheme" == name)
        return (OpenXmlElement) new ColorScheme();
      if (10 == (int) namespaceId && "clrMap" == name)
        return (OpenXmlElement) new ColorMap();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ExtraColorScheme.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ExtraColorScheme.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ColorScheme ColorScheme
    {
      get
      {
        return this.GetElement<ColorScheme>(0);
      }
      set
      {
        this.SetElement<ColorScheme>(0, value);
      }
    }

    public ColorMap ColorMap
    {
      get
      {
        return this.GetElement<ColorMap>(1);
      }
      set
      {
        this.SetElement<ColorMap>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExtraColorScheme>(deep);
    }
  }
}
