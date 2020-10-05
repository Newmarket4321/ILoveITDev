// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.StringDataType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (StringPoint))]
  [ChildElementInfo(typeof (PointCount))]
  [ChildElementInfo(typeof (StrDataExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class StringDataType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "ptCount",
      "pt",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "ptCount" == name)
        return (OpenXmlElement) new PointCount();
      if (11 == (int) namespaceId && "pt" == name)
        return (OpenXmlElement) new StringPoint();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new StrDataExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StringDataType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StringDataType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PointCount PointCount
    {
      get
      {
        return this.GetElement<PointCount>(0);
      }
      set
      {
        this.SetElement<PointCount>(0, value);
      }
    }

    protected StringDataType()
    {
    }

    protected StringDataType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected StringDataType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected StringDataType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
