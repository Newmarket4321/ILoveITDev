// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.DataValidationForumla1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class DataValidationForumla1 : DataValidationFormulaType
  {
    private const string tagName = "formula1";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12999;

    public override string LocalName
    {
      get
      {
        return "formula1";
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
        return 12999;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataValidationForumla1()
    {
    }

    public DataValidationForumla1(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataValidationForumla1(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataValidationForumla1(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataValidationForumla1>(deep);
    }
  }
}
