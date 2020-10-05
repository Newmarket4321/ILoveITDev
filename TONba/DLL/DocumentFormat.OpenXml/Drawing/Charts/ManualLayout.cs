// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ManualLayout
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (Top))]
  [ChildElementInfo(typeof (LeftMode))]
  [ChildElementInfo(typeof (TopMode))]
  [ChildElementInfo(typeof (WidthMode))]
  [ChildElementInfo(typeof (HeightMode))]
  [ChildElementInfo(typeof (Left))]
  [ChildElementInfo(typeof (LayoutTarget))]
  [ChildElementInfo(typeof (Width))]
  [ChildElementInfo(typeof (Height))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class ManualLayout : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[10]
    {
      "layoutTarget",
      "xMode",
      "yMode",
      "wMode",
      "hMode",
      "x",
      "y",
      "w",
      "h",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "manualLayout";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10416;

    public override string LocalName
    {
      get
      {
        return "manualLayout";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10416;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ManualLayout()
    {
    }

    public ManualLayout(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ManualLayout(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ManualLayout(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "layoutTarget" == name)
        return (OpenXmlElement) new LayoutTarget();
      if (11 == (int) namespaceId && "xMode" == name)
        return (OpenXmlElement) new LeftMode();
      if (11 == (int) namespaceId && "yMode" == name)
        return (OpenXmlElement) new TopMode();
      if (11 == (int) namespaceId && "wMode" == name)
        return (OpenXmlElement) new WidthMode();
      if (11 == (int) namespaceId && "hMode" == name)
        return (OpenXmlElement) new HeightMode();
      if (11 == (int) namespaceId && "x" == name)
        return (OpenXmlElement) new Left();
      if (11 == (int) namespaceId && "y" == name)
        return (OpenXmlElement) new Top();
      if (11 == (int) namespaceId && "w" == name)
        return (OpenXmlElement) new Width();
      if (11 == (int) namespaceId && "h" == name)
        return (OpenXmlElement) new Height();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ManualLayout.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ManualLayout.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LayoutTarget LayoutTarget
    {
      get
      {
        return this.GetElement<LayoutTarget>(0);
      }
      set
      {
        this.SetElement<LayoutTarget>(0, value);
      }
    }

    public LeftMode LeftMode
    {
      get
      {
        return this.GetElement<LeftMode>(1);
      }
      set
      {
        this.SetElement<LeftMode>(1, value);
      }
    }

    public TopMode TopMode
    {
      get
      {
        return this.GetElement<TopMode>(2);
      }
      set
      {
        this.SetElement<TopMode>(2, value);
      }
    }

    public WidthMode WidthMode
    {
      get
      {
        return this.GetElement<WidthMode>(3);
      }
      set
      {
        this.SetElement<WidthMode>(3, value);
      }
    }

    public HeightMode HeightMode
    {
      get
      {
        return this.GetElement<HeightMode>(4);
      }
      set
      {
        this.SetElement<HeightMode>(4, value);
      }
    }

    public Left Left
    {
      get
      {
        return this.GetElement<Left>(5);
      }
      set
      {
        this.SetElement<Left>(5, value);
      }
    }

    public Top Top
    {
      get
      {
        return this.GetElement<Top>(6);
      }
      set
      {
        this.SetElement<Top>(6, value);
      }
    }

    public Width Width
    {
      get
      {
        return this.GetElement<Width>(7);
      }
      set
      {
        this.SetElement<Width>(7, value);
      }
    }

    public Height Height
    {
      get
      {
        return this.GetElement<Height>(8);
      }
      set
      {
        this.SetElement<Height>(8, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(9);
      }
      set
      {
        this.SetElement<ExtensionList>(9, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ManualLayout>(deep);
    }
  }
}
