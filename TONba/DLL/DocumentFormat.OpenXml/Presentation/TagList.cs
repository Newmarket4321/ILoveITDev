// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TagList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Tag))]
  [GeneratedCode("DomGen", "2.0")]
  public class TagList : OpenXmlPartRootElement
  {
    private const string tagName = "tagLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12245;

    public override string LocalName
    {
      get
      {
        return "tagLst";
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
        return 12245;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal TagList(UserDefinedTagsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(UserDefinedTagsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public UserDefinedTagsPart UserDefinedTagsPart
    {
      get
      {
        return this.OpenXmlPart as UserDefinedTagsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public TagList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TagList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TagList(string outerXml)
      : base(outerXml)
    {
    }

    public TagList()
    {
    }

    public void Save(UserDefinedTagsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tag" == name)
        return (OpenXmlElement) new Tag();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TagList>(deep);
    }
  }
}
