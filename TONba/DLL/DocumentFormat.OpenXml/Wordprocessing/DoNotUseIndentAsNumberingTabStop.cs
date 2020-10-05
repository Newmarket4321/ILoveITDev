// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DoNotUseIndentAsNumberingTabStop
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class DoNotUseIndentAsNumberingTabStop : OnOffType
  {
    private const string tagName = "doNotUseIndentAsNumberingTabStop";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12045;

    public override string LocalName
    {
      get
      {
        return "doNotUseIndentAsNumberingTabStop";
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
        return 12045;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DoNotUseIndentAsNumberingTabStop>(deep);
    }
  }
}
