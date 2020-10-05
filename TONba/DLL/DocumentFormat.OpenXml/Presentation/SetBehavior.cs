// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SetBehavior
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonBehavior))]
  [ChildElementInfo(typeof (ToVariantValue))]
  public class SetBehavior : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "cBhvr",
      "to"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "set";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12269;

    public override string LocalName
    {
      get
      {
        return "set";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12269;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SetBehavior()
    {
    }

    public SetBehavior(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SetBehavior(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SetBehavior(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      if (24 == (int) namespaceId && "to" == name)
        return (OpenXmlElement) new ToVariantValue();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SetBehavior.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SetBehavior.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonBehavior CommonBehavior
    {
      get
      {
        return this.GetElement<CommonBehavior>(0);
      }
      set
      {
        this.SetElement<CommonBehavior>(0, value);
      }
    }

    public ToVariantValue ToVariantValue
    {
      get
      {
        return this.GetElement<ToVariantValue>(1);
      }
      set
      {
        this.SetElement<ToVariantValue>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SetBehavior>(deep);
    }
  }
}
