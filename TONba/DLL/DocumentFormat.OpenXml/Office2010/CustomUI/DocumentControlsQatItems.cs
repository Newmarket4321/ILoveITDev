// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class DocumentControlsQatItems : QatItemsType
  {
    private const string tagName = "documentControls";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13151;

    public override string LocalName
    {
      get
      {
        return "documentControls";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13151;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocumentControlsQatItems()
    {
    }

    public DocumentControlsQatItems(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocumentControlsQatItems(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocumentControlsQatItems(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentControlsQatItems>(deep);
    }
  }
}
