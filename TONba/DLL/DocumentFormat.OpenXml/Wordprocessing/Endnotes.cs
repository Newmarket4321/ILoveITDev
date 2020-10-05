// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Endnotes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Endnote))]
  [GeneratedCode("DomGen", "2.0")]
  public class Endnotes : OpenXmlPartRootElement
  {
    private const string tagName = "endnotes";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11757;

    public override string LocalName
    {
      get
      {
        return "endnotes";
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
        return 11757;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Endnotes(EndnotesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(EndnotesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public EndnotesPart EndnotesPart
    {
      get
      {
        return this.OpenXmlPart as EndnotesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Endnotes(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Endnotes(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Endnotes(string outerXml)
      : base(outerXml)
    {
    }

    public Endnotes()
    {
    }

    public void Save(EndnotesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "endnote" == name)
        return (OpenXmlElement) new Endnote();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Endnotes>(deep);
    }
  }
}
