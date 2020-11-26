﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.EffectPropertiesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (EffectDag))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EffectList))]
  public class EffectPropertiesType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "effectLst",
      "effectDag"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "effect";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10095;

    public override string LocalName
    {
      get
      {
        return "effect";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10095;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EffectPropertiesType()
    {
    }

    public EffectPropertiesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EffectPropertiesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EffectPropertiesType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return EffectPropertiesType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return EffectPropertiesType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public EffectList EffectList
    {
      get
      {
        return this.GetElement<EffectList>(0);
      }
      set
      {
        this.SetElement<EffectList>(0, value);
      }
    }

    public EffectDag EffectDag
    {
      get
      {
        return this.GetElement<EffectDag>(1);
      }
      set
      {
        this.SetElement<EffectDag>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EffectPropertiesType>(deep);
    }
  }
}