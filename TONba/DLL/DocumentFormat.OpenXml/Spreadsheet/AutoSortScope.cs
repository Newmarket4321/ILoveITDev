// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.AutoSortScope
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (PivotArea))]
  [GeneratedCode("DomGen", "2.0")]
  public class AutoSortScope : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "pivotArea"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "autoSortScope";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11421;

    public override string LocalName
    {
      get
      {
        return "autoSortScope";
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
        return 11421;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AutoSortScope()
    {
    }

    public AutoSortScope(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AutoSortScope(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AutoSortScope(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pivotArea" == name)
        return (OpenXmlElement) new PivotArea();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AutoSortScope.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AutoSortScope.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PivotArea PivotArea
    {
      get
      {
        return this.GetElement<PivotArea>(0);
      }
      set
      {
        this.SetElement<PivotArea>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AutoSortScope>(deep);
    }
  }
}
