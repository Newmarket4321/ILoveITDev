// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.NameOrCorporateType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [ChildElementInfo(typeof (NameList))]
  [ChildElementInfo(typeof (Corporate))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class NameOrCorporateType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      nameof (NameList),
      nameof (Corporate)
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 9,
      (byte) 9
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "NameList" == name)
        return (OpenXmlElement) new NameList();
      if (9 == (int) namespaceId && "Corporate" == name)
        return (OpenXmlElement) new Corporate();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NameOrCorporateType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NameOrCorporateType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public NameList NameList
    {
      get
      {
        return this.GetElement<NameList>(0);
      }
      set
      {
        this.SetElement<NameList>(0, value);
      }
    }

    public Corporate Corporate
    {
      get
      {
        return this.GetElement<Corporate>(1);
      }
      set
      {
        this.SetElement<Corporate>(1, value);
      }
    }

    protected NameOrCorporateType()
    {
    }

    protected NameOrCorporateType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected NameOrCorporateType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected NameOrCorporateType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
