// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.UpDownBars
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (UpBars))]
  [ChildElementInfo(typeof (GapWidth))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (DownBars))]
  public class UpDownBars : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "gapWidth",
      "upBars",
      "downBars",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "upDownBars";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10566;

    public override string LocalName
    {
      get
      {
        return "upDownBars";
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
        return 10566;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public UpDownBars()
    {
    }

    public UpDownBars(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public UpDownBars(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public UpDownBars(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "gapWidth" == name)
        return (OpenXmlElement) new GapWidth();
      if (11 == (int) namespaceId && "upBars" == name)
        return (OpenXmlElement) new UpBars();
      if (11 == (int) namespaceId && "downBars" == name)
        return (OpenXmlElement) new DownBars();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return UpDownBars.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return UpDownBars.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GapWidth GapWidth
    {
      get
      {
        return this.GetElement<GapWidth>(0);
      }
      set
      {
        this.SetElement<GapWidth>(0, value);
      }
    }

    public UpBars UpBars
    {
      get
      {
        return this.GetElement<UpBars>(1);
      }
      set
      {
        this.SetElement<UpBars>(1, value);
      }
    }

    public DownBars DownBars
    {
      get
      {
        return this.GetElement<DownBars>(2);
      }
      set
      {
        this.SetElement<DownBars>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<UpDownBars>(deep);
    }
  }
}
