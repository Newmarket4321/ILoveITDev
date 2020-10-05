// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotCacheRecord
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (FieldItem))]
  [ChildElementInfo(typeof (ErrorItem))]
  [ChildElementInfo(typeof (MissingItem))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BooleanItem))]
  [ChildElementInfo(typeof (NumberItem))]
  [ChildElementInfo(typeof (StringItem))]
  [ChildElementInfo(typeof (DateTimeItem))]
  public class PivotCacheRecord : OpenXmlCompositeElement
  {
    private const string tagName = "r";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11148;

    public override string LocalName
    {
      get
      {
        return "r";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11148;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotCacheRecord()
    {
    }

    public PivotCacheRecord(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotCacheRecord(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotCacheRecord(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new MissingItem();
      if (22 == (int) namespaceId && "n" == name)
        return (OpenXmlElement) new NumberItem();
      if (22 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new BooleanItem();
      if (22 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new ErrorItem();
      if (22 == (int) namespaceId && "s" == name)
        return (OpenXmlElement) new StringItem();
      if (22 == (int) namespaceId && "d" == name)
        return (OpenXmlElement) new DateTimeItem();
      if (22 == (int) namespaceId && "x" == name)
        return (OpenXmlElement) new FieldItem();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotCacheRecord>(deep);
    }
  }
}
