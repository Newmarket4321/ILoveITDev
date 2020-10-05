// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PivotSource
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (FormatId))]
  [ChildElementInfo(typeof (PivotTableName))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotSource : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "name",
      "fmtId",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "pivotSource";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10644;

    public override string LocalName
    {
      get
      {
        return "pivotSource";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10644;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotSource()
    {
    }

    public PivotSource(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotSource(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotSource(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new PivotTableName();
      if (11 == (int) namespaceId && "fmtId" == name)
        return (OpenXmlElement) new FormatId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotSource.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotSource.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PivotTableName PivotTableName
    {
      get
      {
        return this.GetElement<PivotTableName>(0);
      }
      set
      {
        this.SetElement<PivotTableName>(0, value);
      }
    }

    public FormatId FormatId
    {
      get
      {
        return this.GetElement<FormatId>(1);
      }
      set
      {
        this.SetElement<FormatId>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotSource>(deep);
    }
  }
}
