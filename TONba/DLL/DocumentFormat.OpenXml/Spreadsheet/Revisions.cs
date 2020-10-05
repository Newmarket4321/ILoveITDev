// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Revisions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (RevisionCellChange))]
  [ChildElementInfo(typeof (RevisionConflict))]
  [ChildElementInfo(typeof (RevisionRowColumn))]
  [ChildElementInfo(typeof (RevisionMove))]
  [ChildElementInfo(typeof (RevisionCustomView))]
  [ChildElementInfo(typeof (RevisionSheetName))]
  [ChildElementInfo(typeof (RevisionInsertSheet))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RevisionFormat))]
  [ChildElementInfo(typeof (RevisionAutoFormat))]
  [ChildElementInfo(typeof (RevisionDefinedName))]
  [ChildElementInfo(typeof (RevisionComment))]
  [ChildElementInfo(typeof (RevisionQueryTable))]
  public class Revisions : OpenXmlPartRootElement
  {
    private const string tagName = "revisions";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11103;

    public override string LocalName
    {
      get
      {
        return "revisions";
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
        return 11103;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Revisions(WorkbookRevisionLogPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorkbookRevisionLogPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorkbookRevisionLogPart WorkbookRevisionLogPart
    {
      get
      {
        return this.OpenXmlPart as WorkbookRevisionLogPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Revisions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Revisions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Revisions(string outerXml)
      : base(outerXml)
    {
    }

    public Revisions()
    {
    }

    public void Save(WorkbookRevisionLogPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "rrc" == name)
        return (OpenXmlElement) new RevisionRowColumn();
      if (22 == (int) namespaceId && "rm" == name)
        return (OpenXmlElement) new RevisionMove();
      if (22 == (int) namespaceId && "rcv" == name)
        return (OpenXmlElement) new RevisionCustomView();
      if (22 == (int) namespaceId && "rsnm" == name)
        return (OpenXmlElement) new RevisionSheetName();
      if (22 == (int) namespaceId && "ris" == name)
        return (OpenXmlElement) new RevisionInsertSheet();
      if (22 == (int) namespaceId && "rcc" == name)
        return (OpenXmlElement) new RevisionCellChange();
      if (22 == (int) namespaceId && "rfmt" == name)
        return (OpenXmlElement) new RevisionFormat();
      if (22 == (int) namespaceId && "raf" == name)
        return (OpenXmlElement) new RevisionAutoFormat();
      if (22 == (int) namespaceId && "rdn" == name)
        return (OpenXmlElement) new RevisionDefinedName();
      if (22 == (int) namespaceId && "rcmt" == name)
        return (OpenXmlElement) new RevisionComment();
      if (22 == (int) namespaceId && "rqt" == name)
        return (OpenXmlElement) new RevisionQueryTable();
      if (22 == (int) namespaceId && "rcft" == name)
        return (OpenXmlElement) new RevisionConflict();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Revisions>(deep);
    }
  }
}
