// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Bar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BarProperties))]
  [ChildElementInfo(typeof (Base))]
  public class Bar : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "barPr",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "bar";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10909;

    public override string LocalName
    {
      get
      {
        return "bar";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10909;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Bar()
    {
    }

    public Bar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Bar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Bar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "barPr" == name)
        return (OpenXmlElement) new BarProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Bar.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Bar.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BarProperties BarProperties
    {
      get
      {
        return this.GetElement<BarProperties>(0);
      }
      set
      {
        this.SetElement<BarProperties>(0, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(1);
      }
      set
      {
        this.SetElement<Base>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Bar>(deep);
    }
  }
}
