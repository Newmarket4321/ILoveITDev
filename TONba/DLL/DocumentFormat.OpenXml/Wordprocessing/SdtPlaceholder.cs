// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocPartReference))]
  public class SdtPlaceholder : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "docPart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "placeholder";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12085;

    public override string LocalName
    {
      get
      {
        return "placeholder";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12085;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SdtPlaceholder()
    {
    }

    public SdtPlaceholder(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtPlaceholder(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtPlaceholder(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "docPart" == name)
        return (OpenXmlElement) new DocPartReference();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SdtPlaceholder.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SdtPlaceholder.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocPartReference DocPartReference
    {
      get
      {
        return this.GetElement<DocPartReference>(0);
      }
      set
      {
        this.SetElement<DocPartReference>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtPlaceholder>(deep);
    }
  }
}
