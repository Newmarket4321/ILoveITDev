// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (SequenceOfReferences), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabel), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Explosion), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (InvertIfNegativeBoolean), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Bubble3D), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Marker), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShapeProperties), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class CategoryFilterException : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "sqref",
      "spPr",
      "explosion",
      "invertIfNegative",
      "bubble3D",
      "marker",
      "dLbl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 64,
      (byte) 64,
      (byte) 64,
      (byte) 64,
      (byte) 64,
      (byte) 64,
      (byte) 64
    };
    private const string tagName = "categoryFilterException";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13252;

    public override string LocalName
    {
      get
      {
        return "categoryFilterException";
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
        return 13252;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public CategoryFilterException()
    {
    }

    public CategoryFilterException(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CategoryFilterException(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CategoryFilterException(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new SequenceOfReferences();
      if (64 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (64 == (int) namespaceId && "explosion" == name)
        return (OpenXmlElement) new Explosion();
      if (64 == (int) namespaceId && "invertIfNegative" == name)
        return (OpenXmlElement) new InvertIfNegativeBoolean();
      if (64 == (int) namespaceId && "bubble3D" == name)
        return (OpenXmlElement) new Bubble3D();
      if (64 == (int) namespaceId && "marker" == name)
        return (OpenXmlElement) new Marker();
      if (64 == (int) namespaceId && "dLbl" == name)
        return (OpenXmlElement) new DataLabel();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CategoryFilterException.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CategoryFilterException.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SequenceOfReferences SequenceOfReferences
    {
      get
      {
        return this.GetElement<SequenceOfReferences>(0);
      }
      set
      {
        this.SetElement<SequenceOfReferences>(0, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(1);
      }
      set
      {
        this.SetElement<ShapeProperties>(1, value);
      }
    }

    public Explosion Explosion
    {
      get
      {
        return this.GetElement<Explosion>(2);
      }
      set
      {
        this.SetElement<Explosion>(2, value);
      }
    }

    public InvertIfNegativeBoolean InvertIfNegativeBoolean
    {
      get
      {
        return this.GetElement<InvertIfNegativeBoolean>(3);
      }
      set
      {
        this.SetElement<InvertIfNegativeBoolean>(3, value);
      }
    }

    public Bubble3D Bubble3D
    {
      get
      {
        return this.GetElement<Bubble3D>(4);
      }
      set
      {
        this.SetElement<Bubble3D>(4, value);
      }
    }

    public Marker Marker
    {
      get
      {
        return this.GetElement<Marker>(5);
      }
      set
      {
        this.SetElement<Marker>(5, value);
      }
    }

    public DataLabel DataLabel
    {
      get
      {
        return this.GetElement<DataLabel>(6);
      }
      set
      {
        this.SetElement<DataLabel>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CategoryFilterException>(deep);
    }
  }
}
