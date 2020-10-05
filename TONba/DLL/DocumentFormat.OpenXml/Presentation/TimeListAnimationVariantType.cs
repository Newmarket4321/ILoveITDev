// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeListAnimationVariantType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (StringVariantValue))]
  [ChildElementInfo(typeof (ColorValue))]
  [ChildElementInfo(typeof (IntegerVariantValue))]
  [ChildElementInfo(typeof (FloatVariantValue))]
  [ChildElementInfo(typeof (BooleanVariantValue))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class TimeListAnimationVariantType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "boolVal",
      "intVal",
      "fltVal",
      "strVal",
      "clrVal"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "boolVal" == name)
        return (OpenXmlElement) new BooleanVariantValue();
      if (24 == (int) namespaceId && "intVal" == name)
        return (OpenXmlElement) new IntegerVariantValue();
      if (24 == (int) namespaceId && "fltVal" == name)
        return (OpenXmlElement) new FloatVariantValue();
      if (24 == (int) namespaceId && "strVal" == name)
        return (OpenXmlElement) new StringVariantValue();
      if (24 == (int) namespaceId && "clrVal" == name)
        return (OpenXmlElement) new ColorValue();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TimeListAnimationVariantType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TimeListAnimationVariantType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public BooleanVariantValue BooleanVariantValue
    {
      get
      {
        return this.GetElement<BooleanVariantValue>(0);
      }
      set
      {
        this.SetElement<BooleanVariantValue>(0, value);
      }
    }

    public IntegerVariantValue IntegerVariantValue
    {
      get
      {
        return this.GetElement<IntegerVariantValue>(1);
      }
      set
      {
        this.SetElement<IntegerVariantValue>(1, value);
      }
    }

    public FloatVariantValue FloatVariantValue
    {
      get
      {
        return this.GetElement<FloatVariantValue>(2);
      }
      set
      {
        this.SetElement<FloatVariantValue>(2, value);
      }
    }

    public StringVariantValue StringVariantValue
    {
      get
      {
        return this.GetElement<StringVariantValue>(3);
      }
      set
      {
        this.SetElement<StringVariantValue>(3, value);
      }
    }

    public ColorValue ColorValue
    {
      get
      {
        return this.GetElement<ColorValue>(4);
      }
      set
      {
        this.SetElement<ColorValue>(4, value);
      }
    }

    protected TimeListAnimationVariantType()
    {
    }

    protected TimeListAnimationVariantType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TimeListAnimationVariantType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TimeListAnimationVariantType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
