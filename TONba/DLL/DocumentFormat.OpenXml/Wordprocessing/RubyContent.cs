// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RubyContent
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class RubyContent : RubyContentType
  {
    private const string tagName = "rt";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11822;

    public override string LocalName
    {
      get
      {
        return "rt";
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
        return 11822;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RubyContent()
    {
    }

    public RubyContent(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RubyContent(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RubyContent(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RubyContent>(deep);
    }
  }
}
