// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.WorksheetDrawing
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (TwoCellAnchor))]
  [ChildElementInfo(typeof (OneCellAnchor))]
  [ChildElementInfo(typeof (AbsoluteAnchor))]
  [GeneratedCode("DomGen", "2.0")]
  public class WorksheetDrawing : OpenXmlPartRootElement
  {
    private const string tagName = "wsDr";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10795;

    public override string LocalName
    {
      get
      {
        return "wsDr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10795;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal WorksheetDrawing(DrawingsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DrawingsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DrawingsPart DrawingsPart
    {
      get
      {
        return this.OpenXmlPart as DrawingsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public WorksheetDrawing(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WorksheetDrawing(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WorksheetDrawing(string outerXml)
      : base(outerXml)
    {
    }

    public WorksheetDrawing()
    {
    }

    public void Save(DrawingsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (18 == (int) namespaceId && "twoCellAnchor" == name)
        return (OpenXmlElement) new TwoCellAnchor();
      if (18 == (int) namespaceId && "oneCellAnchor" == name)
        return (OpenXmlElement) new OneCellAnchor();
      if (18 == (int) namespaceId && "absoluteAnchor" == name)
        return (OpenXmlElement) new AbsoluteAnchor();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WorksheetDrawing>(deep);
    }
  }
}
