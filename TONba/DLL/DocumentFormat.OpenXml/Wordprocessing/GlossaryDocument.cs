// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocumentBackground))]
  [ChildElementInfo(typeof (DocParts))]
  public class GlossaryDocument : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "background",
      "docParts"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "glossaryDocument";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11766;

    public override string LocalName
    {
      get
      {
        return "glossaryDocument";
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
        return 11766;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal GlossaryDocument(GlossaryDocumentPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(GlossaryDocumentPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public GlossaryDocumentPart GlossaryDocumentPart
    {
      get
      {
        return this.OpenXmlPart as GlossaryDocumentPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public GlossaryDocument(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GlossaryDocument(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GlossaryDocument(string outerXml)
      : base(outerXml)
    {
    }

    public GlossaryDocument()
    {
    }

    public void Save(GlossaryDocumentPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "background" == name)
        return (OpenXmlElement) new DocumentBackground();
      if (23 == (int) namespaceId && "docParts" == name)
        return (OpenXmlElement) new DocParts();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GlossaryDocument.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GlossaryDocument.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocumentBackground DocumentBackground
    {
      get
      {
        return this.GetElement<DocumentBackground>(0);
      }
      set
      {
        this.SetElement<DocumentBackground>(0, value);
      }
    }

    public DocParts DocParts
    {
      get
      {
        return this.GetElement<DocParts>(1);
      }
      set
      {
        this.SetElement<DocParts>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GlossaryDocument>(deep);
    }
  }
}
