// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.Person
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [ChildElementInfo(typeof (Middle))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Last))]
  [ChildElementInfo(typeof (First))]
  public class Person : OpenXmlCompositeElement
  {
    private const string tagName = "Person";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10825;

    public override string LocalName
    {
      get
      {
        return nameof (Person);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10825;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Person()
    {
    }

    public Person(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Person(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Person(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "Last" == name)
        return (OpenXmlElement) new Last();
      if (9 == (int) namespaceId && "First" == name)
        return (OpenXmlElement) new First();
      if (9 == (int) namespaceId && "Middle" == name)
        return (OpenXmlElement) new Middle();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Person>(deep);
    }
  }
}
