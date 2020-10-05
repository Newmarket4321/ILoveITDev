// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableDescription
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class TableDescription : StringType
  {
    private const string tagName = "tblDescription";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11847;

    public override string LocalName
    {
      get
      {
        return "tblDescription";
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
        return 11847;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableDescription>(deep);
    }
  }
}
