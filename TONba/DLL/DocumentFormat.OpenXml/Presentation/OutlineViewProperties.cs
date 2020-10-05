// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.OutlineViewProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonViewProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OutlineViewSlideList))]
  public class OutlineViewProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "cViewPr",
      "sldLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "outlineViewPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12357;

    public override string LocalName
    {
      get
      {
        return "outlineViewPr";
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
        return 12357;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public OutlineViewProperties()
    {
    }

    public OutlineViewProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OutlineViewProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OutlineViewProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cViewPr" == name)
        return (OpenXmlElement) new CommonViewProperties();
      if (24 == (int) namespaceId && "sldLst" == name)
        return (OpenXmlElement) new OutlineViewSlideList();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OutlineViewProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OutlineViewProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonViewProperties CommonViewProperties
    {
      get
      {
        return this.GetElement<CommonViewProperties>(0);
      }
      set
      {
        this.SetElement<CommonViewProperties>(0, value);
      }
    }

    public OutlineViewSlideList OutlineViewSlideList
    {
      get
      {
        return this.GetElement<OutlineViewSlideList>(1);
      }
      set
      {
        this.SetElement<OutlineViewSlideList>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OutlineViewProperties>(deep);
    }
  }
}
