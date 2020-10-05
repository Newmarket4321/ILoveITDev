// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.IntermittentChannels
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Channel))]
  public class IntermittentChannels : OpenXmlCompositeElement
  {
    private const string tagName = "intermittentChannels";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12720;

    public override string LocalName
    {
      get
      {
        return "intermittentChannels";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12720;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public IntermittentChannels()
    {
    }

    public IntermittentChannels(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public IntermittentChannels(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public IntermittentChannels(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "channel" == name)
        return (OpenXmlElement) new Channel();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<IntermittentChannels>(deep);
    }
  }
}
