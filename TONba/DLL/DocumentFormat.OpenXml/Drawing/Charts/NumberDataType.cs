// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.NumberDataType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (PointCount))]
  [ChildElementInfo(typeof (NumericPoint))]
  [ChildElementInfo(typeof (FormatCode))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class NumberDataType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "formatCode",
      "ptCount",
      "pt",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "formatCode" == name)
        return (OpenXmlElement) new FormatCode();
      if (11 == (int) namespaceId && "ptCount" == name)
        return (OpenXmlElement) new PointCount();
      if (11 == (int) namespaceId && "pt" == name)
        return (OpenXmlElement) new NumericPoint();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberDataType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberDataType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FormatCode FormatCode
    {
      get
      {
        return this.GetElement<FormatCode>(0);
      }
      set
      {
        this.SetElement<FormatCode>(0, value);
      }
    }

    public PointCount PointCount
    {
      get
      {
        return this.GetElement<PointCount>(1);
      }
      set
      {
        this.SetElement<PointCount>(1, value);
      }
    }

    protected NumberDataType()
    {
    }

    protected NumberDataType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected NumberDataType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected NumberDataType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
