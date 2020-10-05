// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Box
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BoxProperties))]
  [ChildElementInfo(typeof (Base))]
  public class Box : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "boxPr",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "box";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10910;

    public override string LocalName
    {
      get
      {
        return "box";
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
        return 10910;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Box()
    {
    }

    public Box(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Box(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Box(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "boxPr" == name)
        return (OpenXmlElement) new BoxProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Box.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Box.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BoxProperties BoxProperties
    {
      get
      {
        return this.GetElement<BoxProperties>(0);
      }
      set
      {
        this.SetElement<BoxProperties>(0, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(1);
      }
      set
      {
        this.SetElement<Base>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Box>(deep);
    }
  }
}
