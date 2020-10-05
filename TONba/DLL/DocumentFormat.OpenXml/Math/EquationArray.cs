﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.EquationArray
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EquationArrayProperties))]
  [ChildElementInfo(typeof (Base))]
  public class EquationArray : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "eqArrPr",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "eqArr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10913;

    public override string LocalName
    {
      get
      {
        return "eqArr";
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
        return 10913;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EquationArray()
    {
    }

    public EquationArray(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EquationArray(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EquationArray(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "eqArrPr" == name)
        return (OpenXmlElement) new EquationArrayProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return EquationArray.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return EquationArray.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public EquationArrayProperties EquationArrayProperties
    {
      get
      {
        return this.GetElement<EquationArrayProperties>(0);
      }
      set
      {
        this.SetElement<EquationArrayProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EquationArray>(deep);
    }
  }
}
