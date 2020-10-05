// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.NumberReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (NumberingCache))]
  [ChildElementInfo(typeof (Formula))]
  [ChildElementInfo(typeof (NumRefExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class NumberReference : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "f",
      "numCache",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "numRef";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10401;

    public override string LocalName
    {
      get
      {
        return "numRef";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10401;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NumberReference()
    {
    }

    public NumberReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NumberReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NumberReference(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (11 == (int) namespaceId && "numCache" == name)
        return (OpenXmlElement) new NumberingCache();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new NumRefExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberReference.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberReference.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(0);
      }
      set
      {
        this.SetElement<Formula>(0, value);
      }
    }

    public NumberingCache NumberingCache
    {
      get
      {
        return this.GetElement<NumberingCache>(1);
      }
      set
      {
        this.SetElement<NumberingCache>(1, value);
      }
    }

    public NumRefExtensionList NumRefExtensionList
    {
      get
      {
        return this.GetElement<NumRefExtensionList>(2);
      }
      set
      {
        this.SetElement<NumRefExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberReference>(deep);
    }
  }
}
