// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.BorderBoxProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (HideRight))]
  [ChildElementInfo(typeof (StrikeTopLeftToBottomRight))]
  [ChildElementInfo(typeof (ControlProperties))]
  [ChildElementInfo(typeof (HideTop))]
  [ChildElementInfo(typeof (StrikeVertical))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StrikeHorizontal))]
  [ChildElementInfo(typeof (HideLeft))]
  [ChildElementInfo(typeof (HideBottom))]
  [ChildElementInfo(typeof (StrikeBottomLeftToTopRight))]
  public class BorderBoxProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "hideTop",
      "hideBot",
      "hideLeft",
      "hideRight",
      "strikeH",
      "strikeV",
      "strikeBLTR",
      "strikeTLBR",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "borderBoxPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10954;

    public override string LocalName
    {
      get
      {
        return "borderBoxPr";
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
        return 10954;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BorderBoxProperties()
    {
    }

    public BorderBoxProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BorderBoxProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BorderBoxProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "hideTop" == name)
        return (OpenXmlElement) new HideTop();
      if (21 == (int) namespaceId && "hideBot" == name)
        return (OpenXmlElement) new HideBottom();
      if (21 == (int) namespaceId && "hideLeft" == name)
        return (OpenXmlElement) new HideLeft();
      if (21 == (int) namespaceId && "hideRight" == name)
        return (OpenXmlElement) new HideRight();
      if (21 == (int) namespaceId && "strikeH" == name)
        return (OpenXmlElement) new StrikeHorizontal();
      if (21 == (int) namespaceId && "strikeV" == name)
        return (OpenXmlElement) new StrikeVertical();
      if (21 == (int) namespaceId && "strikeBLTR" == name)
        return (OpenXmlElement) new StrikeBottomLeftToTopRight();
      if (21 == (int) namespaceId && "strikeTLBR" == name)
        return (OpenXmlElement) new StrikeTopLeftToBottomRight();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BorderBoxProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BorderBoxProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HideTop HideTop
    {
      get
      {
        return this.GetElement<HideTop>(0);
      }
      set
      {
        this.SetElement<HideTop>(0, value);
      }
    }

    public HideBottom HideBottom
    {
      get
      {
        return this.GetElement<HideBottom>(1);
      }
      set
      {
        this.SetElement<HideBottom>(1, value);
      }
    }

    public HideLeft HideLeft
    {
      get
      {
        return this.GetElement<HideLeft>(2);
      }
      set
      {
        this.SetElement<HideLeft>(2, value);
      }
    }

    public HideRight HideRight
    {
      get
      {
        return this.GetElement<HideRight>(3);
      }
      set
      {
        this.SetElement<HideRight>(3, value);
      }
    }

    public StrikeHorizontal StrikeHorizontal
    {
      get
      {
        return this.GetElement<StrikeHorizontal>(4);
      }
      set
      {
        this.SetElement<StrikeHorizontal>(4, value);
      }
    }

    public StrikeVertical StrikeVertical
    {
      get
      {
        return this.GetElement<StrikeVertical>(5);
      }
      set
      {
        this.SetElement<StrikeVertical>(5, value);
      }
    }

    public StrikeBottomLeftToTopRight StrikeBottomLeftToTopRight
    {
      get
      {
        return this.GetElement<StrikeBottomLeftToTopRight>(6);
      }
      set
      {
        this.SetElement<StrikeBottomLeftToTopRight>(6, value);
      }
    }

    public StrikeTopLeftToBottomRight StrikeTopLeftToBottomRight
    {
      get
      {
        return this.GetElement<StrikeTopLeftToBottomRight>(7);
      }
      set
      {
        this.SetElement<StrikeTopLeftToBottomRight>(7, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(8);
      }
      set
      {
        this.SetElement<ControlProperties>(8, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BorderBoxProperties>(deep);
    }
  }
}
