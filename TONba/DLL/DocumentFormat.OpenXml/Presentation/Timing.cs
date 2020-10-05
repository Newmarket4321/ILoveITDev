// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Timing
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TimeNodeList))]
  [ChildElementInfo(typeof (BuildList))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  [GeneratedCode("DomGen", "2.0")]
  public class Timing : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "tnLst",
      "bldLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "timing";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12369;

    public override string LocalName
    {
      get
      {
        return "timing";
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
        return 12369;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Timing()
    {
    }

    public Timing(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Timing(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Timing(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tnLst" == name)
        return (OpenXmlElement) new TimeNodeList();
      if (24 == (int) namespaceId && "bldLst" == name)
        return (OpenXmlElement) new BuildList();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Timing.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Timing.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TimeNodeList TimeNodeList
    {
      get
      {
        return this.GetElement<TimeNodeList>(0);
      }
      set
      {
        this.SetElement<TimeNodeList>(0, value);
      }
    }

    public BuildList BuildList
    {
      get
      {
        return this.GetElement<BuildList>(1);
      }
      set
      {
        this.SetElement<BuildList>(1, value);
      }
    }

    public ExtensionListWithModification ExtensionListWithModification
    {
      get
      {
        return this.GetElement<ExtensionListWithModification>(2);
      }
      set
      {
        this.SetElement<ExtensionListWithModification>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Timing>(deep);
    }
  }
}
