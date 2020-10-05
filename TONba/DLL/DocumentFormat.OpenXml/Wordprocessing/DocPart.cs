// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DocPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DocPartBody))]
  [ChildElementInfo(typeof (DocPartProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class DocPart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "docPartPr",
      "docPartBody"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "docPart";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11993;

    public override string LocalName
    {
      get
      {
        return "docPart";
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
        return 11993;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocPart()
    {
    }

    public DocPart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocPart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocPart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "docPartPr" == name)
        return (OpenXmlElement) new DocPartProperties();
      if (23 == (int) namespaceId && "docPartBody" == name)
        return (OpenXmlElement) new DocPartBody();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocPart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocPart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocPartProperties DocPartProperties
    {
      get
      {
        return this.GetElement<DocPartProperties>(0);
      }
      set
      {
        this.SetElement<DocPartProperties>(0, value);
      }
    }

    public DocPartBody DocPartBody
    {
      get
      {
        return this.GetElement<DocPartBody>(1);
      }
      set
      {
        this.SetElement<DocPartBody>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocPart>(deep);
    }
  }
}
