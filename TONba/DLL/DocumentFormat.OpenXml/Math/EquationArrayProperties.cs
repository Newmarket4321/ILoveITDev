// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.EquationArrayProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (ObjectDistribution))]
  [ChildElementInfo(typeof (RowSpacingRule))]
  [ChildElementInfo(typeof (RowSpacing))]
  [ChildElementInfo(typeof (MaxDistribution))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BaseJustification))]
  [ChildElementInfo(typeof (ControlProperties))]
  public class EquationArrayProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "baseJc",
      "maxDist",
      "objDist",
      "rSpRule",
      "rSp",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "eqArrPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10966;

    public override string LocalName
    {
      get
      {
        return "eqArrPr";
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
        return 10966;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EquationArrayProperties()
    {
    }

    public EquationArrayProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EquationArrayProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EquationArrayProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "baseJc" == name)
        return (OpenXmlElement) new BaseJustification();
      if (21 == (int) namespaceId && "maxDist" == name)
        return (OpenXmlElement) new MaxDistribution();
      if (21 == (int) namespaceId && "objDist" == name)
        return (OpenXmlElement) new ObjectDistribution();
      if (21 == (int) namespaceId && "rSpRule" == name)
        return (OpenXmlElement) new RowSpacingRule();
      if (21 == (int) namespaceId && "rSp" == name)
        return (OpenXmlElement) new RowSpacing();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return EquationArrayProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return EquationArrayProperties.eleNamespaceIds;
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

    public MaxDistribution MaxDistribution
    {
      get
      {
        return this.GetElement<MaxDistribution>(1);
      }
      set
      {
        this.SetElement<MaxDistribution>(1, value);
      }
    }

    public ObjectDistribution ObjectDistribution
    {
      get
      {
        return this.GetElement<ObjectDistribution>(2);
      }
      set
      {
        this.SetElement<ObjectDistribution>(2, value);
      }
    }

    public RowSpacingRule RowSpacingRule
    {
      get
      {
        return this.GetElement<RowSpacingRule>(3);
      }
      set
      {
        this.SetElement<RowSpacingRule>(3, value);
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

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(5);
      }
      set
      {
        this.SetElement<ControlProperties>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EquationArrayProperties>(deep);
    }
  }
}
