// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.People
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [ChildElementInfo(typeof (Person), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class People : OpenXmlPartRootElement
  {
    private const string tagName = "people";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13339;

    public override string LocalName
    {
      get
      {
        return "people";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13339;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal People(WordprocessingPeoplePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WordprocessingPeoplePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WordprocessingPeoplePart WordprocessingPeoplePart
    {
      get
      {
        return this.OpenXmlPart as WordprocessingPeoplePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public People(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public People(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public People(string outerXml)
      : base(outerXml)
    {
    }

    public People()
    {
    }

    public void Save(WordprocessingPeoplePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "person" == name)
        return (OpenXmlElement) new Person();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<People>(deep);
    }
  }
}
