// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (NumberLiteral))]
  [ChildElementInfo(typeof (NumberReference))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class NumberDataSourceType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "numRef",
      "numLit"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 11,
      (byte) 11
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "numRef" == name)
        return (OpenXmlElement) new NumberReference();
      if (11 == (int) namespaceId && "numLit" == name)
        return (OpenXmlElement) new NumberLiteral();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberDataSourceType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberDataSourceType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public NumberReference NumberReference
    {
      get
      {
        return this.GetElement<NumberReference>(0);
      }
      set
      {
        this.SetElement<NumberReference>(0, value);
      }
    }

    public NumberLiteral NumberLiteral
    {
      get
      {
        return this.GetElement<NumberLiteral>(1);
      }
      set
      {
        this.SetElement<NumberLiteral>(1, value);
      }
    }

    protected NumberDataSourceType()
    {
    }

    protected NumberDataSourceType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected NumberDataSourceType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected NumberDataSourceType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
