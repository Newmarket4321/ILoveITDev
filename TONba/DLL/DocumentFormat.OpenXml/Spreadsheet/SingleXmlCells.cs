// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SingleXmlCells
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SingleXmlCell))]
  public class SingleXmlCells : OpenXmlPartRootElement
  {
    private const string tagName = "singleXmlCells";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11109;

    public override string LocalName
    {
      get
      {
        return "singleXmlCells";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11109;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal SingleXmlCells(SingleCellTablePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SingleCellTablePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SingleCellTablePart SingleCellTablePart
    {
      get
      {
        return this.OpenXmlPart as SingleCellTablePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public SingleXmlCells(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SingleXmlCells(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SingleXmlCells(string outerXml)
      : base(outerXml)
    {
    }

    public SingleXmlCells()
    {
    }

    public void Save(SingleCellTablePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "singleXmlCell" == name)
        return (OpenXmlElement) new SingleXmlCell();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SingleXmlCells>(deep);
    }
  }
}
