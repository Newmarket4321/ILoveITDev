// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Numbering
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AbstractNum))]
  [ChildElementInfo(typeof (NumberingIdMacAtCleanup))]
  [ChildElementInfo(typeof (NumberingPictureBullet))]
  [ChildElementInfo(typeof (NumberingInstance))]
  public class Numbering : OpenXmlPartRootElement
  {
    private const string tagName = "numbering";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11763;

    public override string LocalName
    {
      get
      {
        return "numbering";
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
        return 11763;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Numbering(NumberingDefinitionsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(NumberingDefinitionsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public NumberingDefinitionsPart NumberingDefinitionsPart
    {
      get
      {
        return this.OpenXmlPart as NumberingDefinitionsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Numbering(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Numbering(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Numbering(string outerXml)
      : base(outerXml)
    {
    }

    public Numbering()
    {
    }

    public void Save(NumberingDefinitionsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "numPicBullet" == name)
        return (OpenXmlElement) new NumberingPictureBullet();
      if (23 == (int) namespaceId && "abstractNum" == name)
        return (OpenXmlElement) new AbstractNum();
      if (23 == (int) namespaceId && "num" == name)
        return (OpenXmlElement) new NumberingInstance();
      if (23 == (int) namespaceId && "numIdMacAtCleanup" == name)
        return (OpenXmlElement) new NumberingIdMacAtCleanup();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Numbering>(deep);
    }
  }
}
