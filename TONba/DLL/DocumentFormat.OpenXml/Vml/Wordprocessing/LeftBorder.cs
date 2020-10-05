// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class LeftBorder : BorderType
  {
    private const string tagName = "borderleft";
    private const byte tagNsId = 28;
    internal const int ElementTypeIdConst = 12502;

    public override string LocalName
    {
      get
      {
        return "borderleft";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 28;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12502;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LeftBorder>(deep);
    }
  }
}
