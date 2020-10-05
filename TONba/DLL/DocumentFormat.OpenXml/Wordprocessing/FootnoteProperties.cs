// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (NumberingRestart))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FootnotePosition))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (NumberingStart))]
  public class FootnoteProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "pos",
      "numFmt",
      "numStart",
      "numRestart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "footnotePr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11736;

    public override string LocalName
    {
      get
      {
        return "footnotePr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11736;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FootnoteProperties()
    {
    }

    public FootnoteProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FootnoteProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FootnoteProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new FootnotePosition();
      if (23 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new NumberingFormat();
      if (23 == (int) namespaceId && "numStart" == name)
        return (OpenXmlElement) new NumberingStart();
      if (23 == (int) namespaceId && "numRestart" == name)
        return (OpenXmlElement) new NumberingRestart();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FootnoteProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FootnoteProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FootnotePosition FootnotePosition
    {
      get
      {
        return this.GetElement<FootnotePosition>(0);
      }
      set
      {
        this.SetElement<FootnotePosition>(0, value);
      }
    }

    public NumberingFormat NumberingFormat
    {
      get
      {
        return this.GetElement<NumberingFormat>(1);
      }
      set
      {
        this.SetElement<NumberingFormat>(1, value);
      }
    }

    public NumberingStart NumberingStart
    {
      get
      {
        return this.GetElement<NumberingStart>(2);
      }
      set
      {
        this.SetElement<NumberingStart>(2, value);
      }
    }

    public NumberingRestart NumberingRestart
    {
      get
      {
        return this.GetElement<NumberingRestart>(3);
      }
      set
      {
        this.SetElement<NumberingRestart>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FootnoteProperties>(deep);
    }
  }
}
