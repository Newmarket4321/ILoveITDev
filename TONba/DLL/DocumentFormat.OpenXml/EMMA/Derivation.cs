// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Derivation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Interpretation))]
  [ChildElementInfo(typeof (Sequence))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (OneOf))]
  public class Derivation : OpenXmlCompositeElement
  {
    private const string tagName = "derivation";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12750;

    public override string LocalName
    {
      get
      {
        return "derivation";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 44;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12750;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Derivation()
    {
    }

    public Derivation(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Derivation(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Derivation(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "interpretation" == name)
        return (OpenXmlElement) new Interpretation();
      if (44 == (int) namespaceId && "one-of" == name)
        return (OpenXmlElement) new OneOf();
      if (44 == (int) namespaceId && "sequence" == name)
        return (OpenXmlElement) new Sequence();
      if (44 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Derivation>(deep);
    }
  }
}
