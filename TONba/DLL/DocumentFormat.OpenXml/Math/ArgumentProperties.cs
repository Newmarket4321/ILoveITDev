﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.ArgumentProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (ArgumentSize))]
  [GeneratedCode("DomGen", "2.0")]
  public class ArgumentProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "argSz"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 21
    };
    private const string tagName = "argPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 11010;

    public override string LocalName
    {
      get
      {
        return "argPr";
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
        return 11010;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ArgumentProperties()
    {
    }

    public ArgumentProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ArgumentProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ArgumentProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "argSz" == name)
        return (OpenXmlElement) new ArgumentSize();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ArgumentProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ArgumentProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ArgumentSize ArgumentSize
    {
      get
      {
        return this.GetElement<ArgumentSize>(0);
      }
      set
      {
        this.SetElement<ArgumentSize>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ArgumentProperties>(deep);
    }
  }
}
