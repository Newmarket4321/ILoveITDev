// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WordprocessingCanvas
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Pictures;
using DocumentFormat.OpenXml.Office2010.Word.DrawingGroup;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GraphicFrameType), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (WholeFormatting), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WordprocessingShape), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (BackgroundFormatting), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WordprocessingGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class WordprocessingCanvas : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "bg",
      "whole",
      "wsp",
      "pic",
      "contentPart",
      "wgp",
      "graphicFrame",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 59,
      (byte) 59,
      (byte) 61,
      (byte) 17,
      (byte) 52,
      (byte) 60,
      (byte) 59,
      (byte) 59
    };
    private const string tagName = "wpc";
    private const byte tagNsId = 59;
    internal const int ElementTypeIdConst = 13182;

    public override string LocalName
    {
      get
      {
        return "wpc";
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
        return 13182;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public WordprocessingCanvas()
    {
    }

    public WordprocessingCanvas(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WordprocessingCanvas(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WordprocessingCanvas(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (59 == (int) namespaceId && "bg" == name)
        return (OpenXmlElement) new BackgroundFormatting();
      if (59 == (int) namespaceId && "whole" == name)
        return (OpenXmlElement) new WholeFormatting();
      if (61 == (int) namespaceId && "wsp" == name)
        return (OpenXmlElement) new WordprocessingShape();
      if (17 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (52 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (60 == (int) namespaceId && "wgp" == name)
        return (OpenXmlElement) new WordprocessingGroup();
      if (59 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrameType();
      if (59 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WordprocessingCanvas.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WordprocessingCanvas.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BackgroundFormatting BackgroundFormatting
    {
      get
      {
        return this.GetElement<BackgroundFormatting>(0);
      }
      set
      {
        this.SetElement<BackgroundFormatting>(0, value);
      }
    }

    public WholeFormatting WholeFormatting
    {
      get
      {
        return this.GetElement<WholeFormatting>(1);
      }
      set
      {
        this.SetElement<WholeFormatting>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WordprocessingCanvas>(deep);
    }
  }
}
