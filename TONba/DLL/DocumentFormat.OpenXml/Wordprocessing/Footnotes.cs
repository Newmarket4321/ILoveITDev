// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Footnotes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Footnote))]
  public class Footnotes : OpenXmlPartRootElement
  {
    private const string tagName = "footnotes";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11756;

    public override string LocalName
    {
      get
      {
        return "footnotes";
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
        return 11756;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Footnotes(FootnotesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(FootnotesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public FootnotesPart FootnotesPart
    {
      get
      {
        return this.OpenXmlPart as FootnotesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Footnotes(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Footnotes(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Footnotes(string outerXml)
      : base(outerXml)
    {
    }

    public Footnotes()
    {
    }

    public void Save(FootnotesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "footnote" == name)
        return (OpenXmlElement) new Footnote();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Footnotes>(deep);
    }
  }
}
