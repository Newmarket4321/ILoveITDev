// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.ChannelProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (ChannelProperty))]
  [GeneratedCode("DomGen", "2.0")]
  public class ChannelProperties : OpenXmlCompositeElement
  {
    private const string tagName = "channelProperties";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12727;

    public override string LocalName
    {
      get
      {
        return "channelProperties";
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
        return 12727;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ChannelProperties()
    {
    }

    public ChannelProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChannelProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChannelProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "channelProperty" == name)
        return (OpenXmlElement) new ChannelProperty();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ChannelProperties>(deep);
    }
  }
}
