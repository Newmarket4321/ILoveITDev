﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.NumberingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (NumberingLevelReference))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NumberingId))]
  [ChildElementInfo(typeof (NumberingChange))]
  [ChildElementInfo(typeof (Inserted))]
  public class NumberingProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "ilvl",
      "numId",
      "numberingChange",
      "ins"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "numPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11562;

    public override string LocalName
    {
      get
      {
        return "numPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11562;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NumberingProperties()
    {
    }

    public NumberingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NumberingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NumberingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "ilvl" == name)
        return (OpenXmlElement) new NumberingLevelReference();
      if (23 == (int) namespaceId && "numId" == name)
        return (OpenXmlElement) new NumberingId();
      if (23 == (int) namespaceId && "numberingChange" == name)
        return (OpenXmlElement) new NumberingChange();
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new Inserted();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NumberingLevelReference NumberingLevelReference
    {
      get
      {
        return this.GetElement<NumberingLevelReference>(0);
      }
      set
      {
        this.SetElement<NumberingLevelReference>(0, value);
      }
    }

    public NumberingId NumberingId
    {
      get
      {
        return this.GetElement<NumberingId>(1);
      }
      set
      {
        this.SetElement<NumberingId>(1, value);
      }
    }

    public NumberingChange NumberingChange
    {
      get
      {
        return this.GetElement<NumberingChange>(2);
      }
      set
      {
        this.SetElement<NumberingChange>(2, value);
      }
    }

    public Inserted Inserted
    {
      get
      {
        return this.GetElement<Inserted>(3);
      }
      set
      {
        this.SetElement<Inserted>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingProperties>(deep);
    }
  }
}
