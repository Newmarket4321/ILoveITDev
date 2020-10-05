// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.LimitUpper
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (LimitUpperProperties))]
  [ChildElementInfo(typeof (Limit))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  public class LimitUpper : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "limUppPr",
      "e",
      "lim"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "limUpp";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10918;

    public override string LocalName
    {
      get
      {
        return "limUpp";
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
        return 10918;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LimitUpper()
    {
    }

    public LimitUpper(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LimitUpper(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LimitUpper(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "limUppPr" == name)
        return (OpenXmlElement) new LimitUpperProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      if (21 == (int) namespaceId && "lim" == name)
        return (OpenXmlElement) new Limit();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LimitUpper.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LimitUpper.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LimitUpperProperties LimitUpperProperties
    {
      get
      {
        return this.GetElement<LimitUpperProperties>(0);
      }
      set
      {
        this.SetElement<LimitUpperProperties>(0, value);
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

    public Limit Limit
    {
      get
      {
        return this.GetElement<Limit>(2);
      }
      set
      {
        this.SetElement<Limit>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LimitUpper>(deep);
    }
  }
}
