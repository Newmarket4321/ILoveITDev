﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.NameType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NameList))]
  public abstract class NameType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      nameof (NameList)
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 9
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "NameList" == name)
        return (OpenXmlElement) new NameList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NameType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NameType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
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

    protected NameType()
    {
    }

    protected NameType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected NameType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected NameType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
