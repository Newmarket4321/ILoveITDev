// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.LongProperties.LongProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.LongProperties
{
  [ChildElementInfo(typeof (LongProperty))]
  [GeneratedCode("DomGen", "2.0")]
  public class LongProperties : OpenXmlCompositeElement
  {
    private const string tagName = "LongProperties";
    private const byte tagNsId = 40;
    internal const int ElementTypeIdConst = 12711;

    public override string LocalName
    {
      get
      {
        return nameof (LongProperties);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 40;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12711;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LongProperties()
    {
    }

    public LongProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LongProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LongProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (40 == (int) namespaceId && "LongProp" == name)
        return (OpenXmlElement) new LongProperty();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office.LongProperties.LongProperties>(deep);
    }
  }
}
