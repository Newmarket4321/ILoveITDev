// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.VariantTypes;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
  [ChildElementInfo(typeof (VTVector))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class VectorVariantType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "vector"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 5
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (5 == (int) namespaceId && "vector" == name)
        return (OpenXmlElement) new VTVector();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return VectorVariantType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return VectorVariantType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public VTVector VTVector
    {
      get
      {
        return this.GetElement<VTVector>(0);
      }
      set
      {
        this.SetElement<VTVector>(0, value);
      }
    }

    protected VectorVariantType()
    {
    }

    protected VectorVariantType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected VectorVariantType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected VectorVariantType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
