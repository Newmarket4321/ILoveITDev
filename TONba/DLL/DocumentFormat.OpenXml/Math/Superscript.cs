﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Superscript
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  [ChildElementInfo(typeof (SuperArgument))]
  [ChildElementInfo(typeof (SuperscriptProperties))]
  public class Superscript : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "sSupPr",
      "e",
      "sup"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "sSup";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10926;

    public override string LocalName
    {
      get
      {
        return "sSup";
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
        return 10926;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Superscript()
    {
    }

    public Superscript(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Superscript(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Superscript(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "sSupPr" == name)
        return (OpenXmlElement) new SuperscriptProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      if (21 == (int) namespaceId && "sup" == name)
        return (OpenXmlElement) new SuperArgument();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Superscript.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Superscript.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SuperscriptProperties SuperscriptProperties
    {
      get
      {
        return this.GetElement<SuperscriptProperties>(0);
      }
      set
      {
        this.SetElement<SuperscriptProperties>(0, value);
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

    public SuperArgument SuperArgument
    {
      get
      {
        return this.GetElement<SuperArgument>(2);
      }
      set
      {
        this.SetElement<SuperArgument>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Superscript>(deep);
    }
  }
}
