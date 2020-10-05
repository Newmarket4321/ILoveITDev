// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.AutoCaptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AutoCaption))]
  public class AutoCaptions : OpenXmlCompositeElement
  {
    private const string tagName = "autoCaptions";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11981;

    public override string LocalName
    {
      get
      {
        return "autoCaptions";
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
        return 11981;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AutoCaptions()
    {
    }

    public AutoCaptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AutoCaptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AutoCaptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "autoCaption" == name)
        return (OpenXmlElement) new AutoCaption();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AutoCaptions>(deep);
    }
  }
}
