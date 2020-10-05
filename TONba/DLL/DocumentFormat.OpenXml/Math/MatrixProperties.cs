// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.MatrixProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (RowSpacingRule))]
  [ChildElementInfo(typeof (RowSpacing))]
  [ChildElementInfo(typeof (ControlProperties))]
  [ChildElementInfo(typeof (BaseJustification))]
  [ChildElementInfo(typeof (HidePlaceholder))]
  [ChildElementInfo(typeof (ColumnGapRule))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColumnSpacing))]
  [ChildElementInfo(typeof (ColumnGap))]
  [ChildElementInfo(typeof (MatrixColumns))]
  public class MatrixProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "baseJc",
      "plcHide",
      "rSpRule",
      "cGpRule",
      "rSp",
      "cSp",
      "cGp",
      "mcs",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "mPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10987;

    public override string LocalName
    {
      get
      {
        return "mPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10987;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MatrixProperties()
    {
    }

    public MatrixProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MatrixProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MatrixProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "baseJc" == name)
        return (OpenXmlElement) new BaseJustification();
      if (21 == (int) namespaceId && "plcHide" == name)
        return (OpenXmlElement) new HidePlaceholder();
      if (21 == (int) namespaceId && "rSpRule" == name)
        return (OpenXmlElement) new RowSpacingRule();
      if (21 == (int) namespaceId && "cGpRule" == name)
        return (OpenXmlElement) new ColumnGapRule();
      if (21 == (int) namespaceId && "rSp" == name)
        return (OpenXmlElement) new RowSpacing();
      if (21 == (int) namespaceId && "cSp" == name)
        return (OpenXmlElement) new ColumnSpacing();
      if (21 == (int) namespaceId && "cGp" == name)
        return (OpenXmlElement) new ColumnGap();
      if (21 == (int) namespaceId && "mcs" == name)
        return (OpenXmlElement) new MatrixColumns();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MatrixProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MatrixProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BaseJustification BaseJustification
    {
      get
      {
        return this.GetElement<BaseJustification>(0);
      }
      set
      {
        this.SetElement<BaseJustification>(0, value);
      }
    }

    public HidePlaceholder HidePlaceholder
    {
      get
      {
        return this.GetElement<HidePlaceholder>(1);
      }
      set
      {
        this.SetElement<HidePlaceholder>(1, value);
      }
    }

    public RowSpacingRule RowSpacingRule
    {
      get
      {
        return this.GetElement<RowSpacingRule>(2);
      }
      set
      {
        this.SetElement<RowSpacingRule>(2, value);
      }
    }

    public ColumnGapRule ColumnGapRule
    {
      get
      {
        return this.GetElement<ColumnGapRule>(3);
      }
      set
      {
        this.SetElement<ColumnGapRule>(3, value);
      }
    }

    public RowSpacing RowSpacing
    {
      get
      {
        return this.GetElement<RowSpacing>(4);
      }
      set
      {
        this.SetElement<RowSpacing>(4, value);
      }
    }

    public ColumnSpacing ColumnSpacing
    {
      get
      {
        return this.GetElement<ColumnSpacing>(5);
      }
      set
      {
        this.SetElement<ColumnSpacing>(5, value);
      }
    }

    public ColumnGap ColumnGap
    {
      get
      {
        return this.GetElement<ColumnGap>(6);
      }
      set
      {
        this.SetElement<ColumnGap>(6, value);
      }
    }

    public MatrixColumns MatrixColumns
    {
      get
      {
        return this.GetElement<MatrixColumns>(7);
      }
      set
      {
        this.SetElement<MatrixColumns>(7, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(8);
      }
      set
      {
        this.SetElement<ControlProperties>(8, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MatrixProperties>(deep);
    }
  }
}
