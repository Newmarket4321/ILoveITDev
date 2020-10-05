// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (AnimationLevel))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HierarchyBranch))]
  [ChildElementInfo(typeof (AnimateOneByOne))]
  [ChildElementInfo(typeof (ResizeHandles))]
  [ChildElementInfo(typeof (Direction))]
  [ChildElementInfo(typeof (BulletEnabled))]
  [ChildElementInfo(typeof (OrganizationChart))]
  [ChildElementInfo(typeof (MaxNumberOfChildren))]
  [ChildElementInfo(typeof (PreferredNumberOfChildren))]
  public abstract class LayoutVariablePropertySetType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "orgChart",
      "chMax",
      "chPref",
      "bulletEnabled",
      "dir",
      "hierBranch",
      "animOne",
      "animLvl",
      "resizeHandles"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14,
      (byte) 14
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "orgChart" == name)
        return (OpenXmlElement) new OrganizationChart();
      if (14 == (int) namespaceId && "chMax" == name)
        return (OpenXmlElement) new MaxNumberOfChildren();
      if (14 == (int) namespaceId && "chPref" == name)
        return (OpenXmlElement) new PreferredNumberOfChildren();
      if (14 == (int) namespaceId && "bulletEnabled" == name)
        return (OpenXmlElement) new BulletEnabled();
      if (14 == (int) namespaceId && "dir" == name)
        return (OpenXmlElement) new Direction();
      if (14 == (int) namespaceId && "hierBranch" == name)
        return (OpenXmlElement) new HierarchyBranch();
      if (14 == (int) namespaceId && "animOne" == name)
        return (OpenXmlElement) new AnimateOneByOne();
      if (14 == (int) namespaceId && "animLvl" == name)
        return (OpenXmlElement) new AnimationLevel();
      if (14 == (int) namespaceId && "resizeHandles" == name)
        return (OpenXmlElement) new ResizeHandles();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LayoutVariablePropertySetType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LayoutVariablePropertySetType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OrganizationChart OrganizationChart
    {
      get
      {
        return this.GetElement<OrganizationChart>(0);
      }
      set
      {
        this.SetElement<OrganizationChart>(0, value);
      }
    }

    public MaxNumberOfChildren MaxNumberOfChildren
    {
      get
      {
        return this.GetElement<MaxNumberOfChildren>(1);
      }
      set
      {
        this.SetElement<MaxNumberOfChildren>(1, value);
      }
    }

    public PreferredNumberOfChildren PreferredNumberOfChildren
    {
      get
      {
        return this.GetElement<PreferredNumberOfChildren>(2);
      }
      set
      {
        this.SetElement<PreferredNumberOfChildren>(2, value);
      }
    }

    public BulletEnabled BulletEnabled
    {
      get
      {
        return this.GetElement<BulletEnabled>(3);
      }
      set
      {
        this.SetElement<BulletEnabled>(3, value);
      }
    }

    public Direction Direction
    {
      get
      {
        return this.GetElement<Direction>(4);
      }
      set
      {
        this.SetElement<Direction>(4, value);
      }
    }

    public HierarchyBranch HierarchyBranch
    {
      get
      {
        return this.GetElement<HierarchyBranch>(5);
      }
      set
      {
        this.SetElement<HierarchyBranch>(5, value);
      }
    }

    public AnimateOneByOne AnimateOneByOne
    {
      get
      {
        return this.GetElement<AnimateOneByOne>(6);
      }
      set
      {
        this.SetElement<AnimateOneByOne>(6, value);
      }
    }

    public AnimationLevel AnimationLevel
    {
      get
      {
        return this.GetElement<AnimationLevel>(7);
      }
      set
      {
        this.SetElement<AnimationLevel>(7, value);
      }
    }

    public ResizeHandles ResizeHandles
    {
      get
      {
        return this.GetElement<ResizeHandles>(8);
      }
      set
      {
        this.SetElement<ResizeHandles>(8, value);
      }
    }

    protected LayoutVariablePropertySetType()
    {
    }

    protected LayoutVariablePropertySetType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected LayoutVariablePropertySetType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected LayoutVariablePropertySetType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
