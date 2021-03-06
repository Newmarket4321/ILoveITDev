﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
  [ChildElementInfo(typeof (EffectDag))]
  [ChildElementInfo(typeof (Outline))]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (EffectList))]
  public class WholeFormatting : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "ln",
      "effectLst",
      "effectDag"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "whole";
    private const byte tagNsId = 59;
    internal const int ElementTypeIdConst = 13184;

    public override string LocalName
    {
      get
      {
        return "whole";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 59;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13184;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public WholeFormatting()
    {
    }

    public WholeFormatting(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WholeFormatting(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WholeFormatting(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "ln" == name)
        return (OpenXmlElement) new Outline();
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
        return WholeFormatting.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WholeFormatting.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Outline Outline
    {
      get
      {
        return this.GetElement<Outline>(0);
      }
      set
      {
        this.SetElement<Outline>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WholeFormatting>(deep);
    }
  }
}
