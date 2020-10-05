// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Formulas
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [ChildElementInfo(typeof (Formula))]
  [GeneratedCode("DomGen", "2.0")]
  public class Formulas : OpenXmlCompositeElement
  {
    private const string tagName = "formulas";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12578;

    public override string LocalName
    {
      get
      {
        return "formulas";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12578;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Formulas()
    {
    }

    public Formulas(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Formulas(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Formulas(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Formulas>(deep);
    }
  }
}
