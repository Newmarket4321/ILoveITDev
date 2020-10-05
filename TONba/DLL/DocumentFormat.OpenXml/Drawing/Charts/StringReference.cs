// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.StringReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StringCache))]
  [ChildElementInfo(typeof (StrRefExtensionList))]
  [ChildElementInfo(typeof (Formula))]
  public class StringReference : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "f",
      "strCache",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "strRef";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10405;

    public override string LocalName
    {
      get
      {
        return "strRef";
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
        return 10405;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public StringReference()
    {
    }

    public StringReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StringReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StringReference(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (11 == (int) namespaceId && "strCache" == name)
        return (OpenXmlElement) new StringCache();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new StrRefExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StringReference.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StringReference.eleNamespaceIds;
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

    public StringCache StringCache
    {
      get
      {
        return this.GetElement<StringCache>(1);
      }
      set
      {
        this.SetElement<StringCache>(1, value);
      }
    }

    public StrRefExtensionList StrRefExtensionList
    {
      get
      {
        return this.GetElement<StrRefExtensionList>(2);
      }
      set
      {
        this.SetElement<StrRefExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StringReference>(deep);
    }
  }
}
