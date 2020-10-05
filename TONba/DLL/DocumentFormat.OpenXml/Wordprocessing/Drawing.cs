// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Drawing
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Anchor))]
  [ChildElementInfo(typeof (Inline))]
  [GeneratedCode("DomGen", "2.0")]
  public class Drawing : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "anchor",
      "inline"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 16,
      (byte) 16
    };
    private const string tagName = "drawing";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11619;

    public override string LocalName
    {
      get
      {
        return "drawing";
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
        return 11619;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Drawing()
    {
    }

    public Drawing(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Drawing(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Drawing(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "anchor" == name)
        return (OpenXmlElement) new Anchor();
      if (16 == (int) namespaceId && "inline" == name)
        return (OpenXmlElement) new Inline();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Wordprocessing.Drawing.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Wordprocessing.Drawing.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public Anchor Anchor
    {
      get
      {
        return this.GetElement<Anchor>(0);
      }
      set
      {
        this.SetElement<Anchor>(0, value);
      }
    }

    public Inline Inline
    {
      get
      {
        return this.GetElement<Inline>(1);
      }
      set
      {
        this.SetElement<Inline>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Wordprocessing.Drawing>(deep);
    }
  }
}
