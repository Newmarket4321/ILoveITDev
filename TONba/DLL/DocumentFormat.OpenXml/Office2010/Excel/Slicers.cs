// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Slicers
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Slicer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class Slicers : OpenXmlPartRootElement
  {
    private const string tagName = "slicers";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12993;

    public override string LocalName
    {
      get
      {
        return "slicers";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12993;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Slicers(SlicersPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlicersPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlicersPart SlicersPart
    {
      get
      {
        return this.OpenXmlPart as SlicersPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Slicers(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Slicers(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Slicers(string outerXml)
      : base(outerXml)
    {
    }

    public Slicers()
    {
    }

    public void Save(SlicersPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "slicer" == name)
        return (OpenXmlElement) new Slicer();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Slicers>(deep);
    }
  }
}
