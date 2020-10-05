// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (Formula), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelsRangeChache), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DataLabelsRange : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "f",
      "dlblRangeCache"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 64,
      (byte) 64
    };
    private const string tagName = "datalabelsRange";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13226;

    public override string LocalName
    {
      get
      {
        return "datalabelsRange";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13226;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public DataLabelsRange()
    {
    }

    public DataLabelsRange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataLabelsRange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataLabelsRange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (64 == (int) namespaceId && "dlblRangeCache" == name)
        return (OpenXmlElement) new DataLabelsRangeChache();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataLabelsRange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataLabelsRange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(0);
      }
      set
      {
        this.SetElement<Formula>(0, value);
      }
    }

    public DataLabelsRangeChache DataLabelsRangeChache
    {
      get
      {
        return this.GetElement<DataLabelsRangeChache>(1);
      }
      set
      {
        this.SetElement<DataLabelsRangeChache>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabelsRange>(deep);
    }
  }
}
