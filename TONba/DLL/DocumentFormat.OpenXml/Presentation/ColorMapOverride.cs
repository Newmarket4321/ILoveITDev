// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ColorMapOverride
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (MasterColorMapping))]
  [ChildElementInfo(typeof (OverrideColorMapping))]
  [GeneratedCode("DomGen", "2.0")]
  public class ColorMapOverride : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "masterClrMapping",
      "overrideClrMapping"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "clrMapOvr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12230;

    public override string LocalName
    {
      get
      {
        return "clrMapOvr";
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
        return 12230;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ColorMapOverride()
    {
    }

    public ColorMapOverride(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorMapOverride(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorMapOverride(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "masterClrMapping" == name)
        return (OpenXmlElement) new MasterColorMapping();
      if (10 == (int) namespaceId && "overrideClrMapping" == name)
        return (OpenXmlElement) new OverrideColorMapping();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ColorMapOverride.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ColorMapOverride.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public MasterColorMapping MasterColorMapping
    {
      get
      {
        return this.GetElement<MasterColorMapping>(0);
      }
      set
      {
        this.SetElement<MasterColorMapping>(0, value);
      }
    }

    public OverrideColorMapping OverrideColorMapping
    {
      get
      {
        return this.GetElement<OverrideColorMapping>(1);
      }
      set
      {
        this.SetElement<OverrideColorMapping>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorMapOverride>(deep);
    }
  }
}
