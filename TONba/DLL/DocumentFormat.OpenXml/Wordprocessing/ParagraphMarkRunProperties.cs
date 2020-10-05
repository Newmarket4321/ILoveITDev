﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (StylisticSets), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ParagraphMarkRunPropertiesChange))]
  [ChildElementInfo(typeof (Glow), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.Shadow), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RightToLeftText))]
  [ChildElementInfo(typeof (ComplexScript))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Deleted))]
  [ChildElementInfo(typeof (MoveFrom))]
  [ChildElementInfo(typeof (MoveTo))]
  [ChildElementInfo(typeof (ConflictInsertion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConflictDeletion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RunStyle))]
  [ChildElementInfo(typeof (RunFonts))]
  [ChildElementInfo(typeof (Bold))]
  [ChildElementInfo(typeof (BoldComplexScript))]
  [ChildElementInfo(typeof (Italic))]
  [ChildElementInfo(typeof (ItalicComplexScript))]
  [ChildElementInfo(typeof (Caps))]
  [ChildElementInfo(typeof (SmallCaps))]
  [ChildElementInfo(typeof (Strike))]
  [ChildElementInfo(typeof (DoubleStrike))]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (Emboss))]
  [ChildElementInfo(typeof (Imprint))]
  [ChildElementInfo(typeof (NoProof))]
  [ChildElementInfo(typeof (SnapToGrid))]
  [ChildElementInfo(typeof (Vanish))]
  [ChildElementInfo(typeof (WebHidden))]
  [ChildElementInfo(typeof (Color))]
  [ChildElementInfo(typeof (Spacing))]
  [ChildElementInfo(typeof (CharacterScale))]
  [ChildElementInfo(typeof (Kern))]
  [ChildElementInfo(typeof (Position))]
  [ChildElementInfo(typeof (FontSize))]
  [ChildElementInfo(typeof (FontSizeComplexScript))]
  [ChildElementInfo(typeof (Highlight))]
  [ChildElementInfo(typeof (Underline))]
  [ChildElementInfo(typeof (TextEffect))]
  [ChildElementInfo(typeof (Border))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (FitText))]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (Inserted))]
  [ChildElementInfo(typeof (Emphasis))]
  [ChildElementInfo(typeof (Languages))]
  [ChildElementInfo(typeof (EastAsianLayout))]
  [ChildElementInfo(typeof (SpecVanish))]
  [ChildElementInfo(typeof (Reflection), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextOutlineEffect), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FillTextEffect), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Scene3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Properties3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Ligatures), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.NumberingFormat), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NumberSpacing), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ContextualAlternatives), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeMath))]
  public class ParagraphMarkRunProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[58]
    {
      "ins",
      "del",
      "moveFrom",
      "moveTo",
      "conflictIns",
      "conflictDel",
      "rStyle",
      "rFonts",
      "b",
      "bCs",
      "i",
      "iCs",
      "caps",
      "smallCaps",
      "strike",
      "dstrike",
      "outline",
      "shadow",
      "emboss",
      "imprint",
      "noProof",
      "snapToGrid",
      "vanish",
      "webHidden",
      "color",
      "spacing",
      "w",
      "kern",
      "position",
      "sz",
      "szCs",
      "highlight",
      "u",
      "effect",
      "bdr",
      "shd",
      "fitText",
      "vertAlign",
      "rtl",
      "cs",
      "em",
      "lang",
      "eastAsianLayout",
      "specVanish",
      "glow",
      "shadow",
      "reflection",
      "textOutline",
      "textFill",
      "scene3d",
      "props3d",
      "ligatures",
      "numForm",
      "numSpacing",
      "stylisticSets",
      "cntxtAlts",
      "oMath",
      "rPrChange"
    };
    private static readonly byte[] eleNamespaceIds = new byte[58]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 52,
      (byte) 52,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "rPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11785;

    public override string LocalName
    {
      get
      {
        return "rPr";
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
        return 11785;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ParagraphMarkRunProperties()
    {
    }

    public ParagraphMarkRunProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ParagraphMarkRunProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ParagraphMarkRunProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new Inserted();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new Deleted();
      if (23 == (int) namespaceId && "moveFrom" == name)
        return (OpenXmlElement) new MoveFrom();
      if (23 == (int) namespaceId && "moveTo" == name)
        return (OpenXmlElement) new MoveTo();
      if (52 == (int) namespaceId && "conflictIns" == name)
        return (OpenXmlElement) new ConflictInsertion();
      if (52 == (int) namespaceId && "conflictDel" == name)
        return (OpenXmlElement) new ConflictDeletion();
      if (23 == (int) namespaceId && "rStyle" == name)
        return (OpenXmlElement) new RunStyle();
      if (23 == (int) namespaceId && "rFonts" == name)
        return (OpenXmlElement) new RunFonts();
      if (23 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new Bold();
      if (23 == (int) namespaceId && "bCs" == name)
        return (OpenXmlElement) new BoldComplexScript();
      if (23 == (int) namespaceId && "i" == name)
        return (OpenXmlElement) new Italic();
      if (23 == (int) namespaceId && "iCs" == name)
        return (OpenXmlElement) new ItalicComplexScript();
      if (23 == (int) namespaceId && "caps" == name)
        return (OpenXmlElement) new Caps();
      if (23 == (int) namespaceId && "smallCaps" == name)
        return (OpenXmlElement) new SmallCaps();
      if (23 == (int) namespaceId && "strike" == name)
        return (OpenXmlElement) new Strike();
      if (23 == (int) namespaceId && "dstrike" == name)
        return (OpenXmlElement) new DoubleStrike();
      if (23 == (int) namespaceId && "outline" == name)
        return (OpenXmlElement) new Outline();
      if (23 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (23 == (int) namespaceId && "emboss" == name)
        return (OpenXmlElement) new Emboss();
      if (23 == (int) namespaceId && "imprint" == name)
        return (OpenXmlElement) new Imprint();
      if (23 == (int) namespaceId && "noProof" == name)
        return (OpenXmlElement) new NoProof();
      if (23 == (int) namespaceId && "snapToGrid" == name)
        return (OpenXmlElement) new SnapToGrid();
      if (23 == (int) namespaceId && "vanish" == name)
        return (OpenXmlElement) new Vanish();
      if (23 == (int) namespaceId && "webHidden" == name)
        return (OpenXmlElement) new WebHidden();
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      if (23 == (int) namespaceId && "spacing" == name)
        return (OpenXmlElement) new Spacing();
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlElement) new CharacterScale();
      if (23 == (int) namespaceId && "kern" == name)
        return (OpenXmlElement) new Kern();
      if (23 == (int) namespaceId && "position" == name)
        return (OpenXmlElement) new Position();
      if (23 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FontSize();
      if (23 == (int) namespaceId && "szCs" == name)
        return (OpenXmlElement) new FontSizeComplexScript();
      if (23 == (int) namespaceId && "highlight" == name)
        return (OpenXmlElement) new Highlight();
      if (23 == (int) namespaceId && "u" == name)
        return (OpenXmlElement) new Underline();
      if (23 == (int) namespaceId && "effect" == name)
        return (OpenXmlElement) new TextEffect();
      if (23 == (int) namespaceId && "bdr" == name)
        return (OpenXmlElement) new Border();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "fitText" == name)
        return (OpenXmlElement) new FitText();
      if (23 == (int) namespaceId && "vertAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignment();
      if (23 == (int) namespaceId && "rtl" == name)
        return (OpenXmlElement) new RightToLeftText();
      if (23 == (int) namespaceId && "cs" == name)
        return (OpenXmlElement) new ComplexScript();
      if (23 == (int) namespaceId && "em" == name)
        return (OpenXmlElement) new Emphasis();
      if (23 == (int) namespaceId && "lang" == name)
        return (OpenXmlElement) new Languages();
      if (23 == (int) namespaceId && "eastAsianLayout" == name)
        return (OpenXmlElement) new EastAsianLayout();
      if (23 == (int) namespaceId && "specVanish" == name)
        return (OpenXmlElement) new SpecVanish();
      if (52 == (int) namespaceId && "glow" == name)
        return (OpenXmlElement) new Glow();
      if (52 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.Shadow();
      if (52 == (int) namespaceId && "reflection" == name)
        return (OpenXmlElement) new Reflection();
      if (52 == (int) namespaceId && "textOutline" == name)
        return (OpenXmlElement) new TextOutlineEffect();
      if (52 == (int) namespaceId && "textFill" == name)
        return (OpenXmlElement) new FillTextEffect();
      if (52 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3D();
      if (52 == (int) namespaceId && "props3d" == name)
        return (OpenXmlElement) new Properties3D();
      if (52 == (int) namespaceId && "ligatures" == name)
        return (OpenXmlElement) new Ligatures();
      if (52 == (int) namespaceId && "numForm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.NumberingFormat();
      if (52 == (int) namespaceId && "numSpacing" == name)
        return (OpenXmlElement) new NumberSpacing();
      if (52 == (int) namespaceId && "stylisticSets" == name)
        return (OpenXmlElement) new StylisticSets();
      if (52 == (int) namespaceId && "cntxtAlts" == name)
        return (OpenXmlElement) new ContextualAlternatives();
      if (23 == (int) namespaceId && "oMath" == name)
        return (OpenXmlElement) new OfficeMath();
      if (23 == (int) namespaceId && "rPrChange" == name)
        return (OpenXmlElement) new ParagraphMarkRunPropertiesChange();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ParagraphMarkRunProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ParagraphMarkRunProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Inserted Inserted
    {
      get
      {
        return this.GetElement<Inserted>(0);
      }
      set
      {
        this.SetElement<Inserted>(0, value);
      }
    }

    public Deleted Deleted
    {
      get
      {
        return this.GetElement<Deleted>(1);
      }
      set
      {
        this.SetElement<Deleted>(1, value);
      }
    }

    public MoveFrom MoveFrom
    {
      get
      {
        return this.GetElement<MoveFrom>(2);
      }
      set
      {
        this.SetElement<MoveFrom>(2, value);
      }
    }

    public MoveTo MoveTo
    {
      get
      {
        return this.GetElement<MoveTo>(3);
      }
      set
      {
        this.SetElement<MoveTo>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ParagraphMarkRunProperties>(deep);
    }
  }
}
