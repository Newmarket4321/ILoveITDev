// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class LeaderLines : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "spPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 11
    };
    private const string tagName = "leaderLines";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13233;

    public override string LocalName
    {
      get
      {
        return "leaderLines";
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
        return 13233;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public LeaderLines()
    {
    }

    public LeaderLines(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LeaderLines(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LeaderLines(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LeaderLines.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LeaderLines.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(0);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LeaderLines>(deep);
    }
  }
}
