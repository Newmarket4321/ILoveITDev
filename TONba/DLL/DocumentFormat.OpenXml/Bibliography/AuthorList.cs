// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.AuthorList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [ChildElementInfo(typeof (Artist))]
  [ChildElementInfo(typeof (Editor))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Author))]
  [ChildElementInfo(typeof (BookAuthor))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Bibliography.Compiler))]
  [ChildElementInfo(typeof (Composer))]
  [ChildElementInfo(typeof (Conductor))]
  [ChildElementInfo(typeof (Counsel))]
  [ChildElementInfo(typeof (Director))]
  [ChildElementInfo(typeof (Interviewee))]
  [ChildElementInfo(typeof (Interviewer))]
  [ChildElementInfo(typeof (Inventor))]
  [ChildElementInfo(typeof (Performer))]
  [ChildElementInfo(typeof (ProducerName))]
  [ChildElementInfo(typeof (Translator))]
  [ChildElementInfo(typeof (Writer))]
  public class AuthorList : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      nameof (Artist),
      nameof (Author),
      nameof (BookAuthor),
      nameof (Compiler),
      nameof (Composer),
      nameof (Conductor),
      nameof (Counsel),
      nameof (Director),
      nameof (Editor),
      nameof (Interviewee),
      nameof (Interviewer),
      nameof (Inventor),
      nameof (Performer),
      nameof (ProducerName),
      nameof (Translator),
      nameof (Writer)
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
    {
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9
    };
    private const string tagName = "Author";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10849;

    public override string LocalName
    {
      get
      {
        return "Author";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10849;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AuthorList()
    {
    }

    public AuthorList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AuthorList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AuthorList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "Artist" == name)
        return (OpenXmlElement) new Artist();
      if (9 == (int) namespaceId && "Author" == name)
        return (OpenXmlElement) new Author();
      if (9 == (int) namespaceId && "BookAuthor" == name)
        return (OpenXmlElement) new BookAuthor();
      if (9 == (int) namespaceId && "Compiler" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Bibliography.Compiler();
      if (9 == (int) namespaceId && "Composer" == name)
        return (OpenXmlElement) new Composer();
      if (9 == (int) namespaceId && "Conductor" == name)
        return (OpenXmlElement) new Conductor();
      if (9 == (int) namespaceId && "Counsel" == name)
        return (OpenXmlElement) new Counsel();
      if (9 == (int) namespaceId && "Director" == name)
        return (OpenXmlElement) new Director();
      if (9 == (int) namespaceId && "Editor" == name)
        return (OpenXmlElement) new Editor();
      if (9 == (int) namespaceId && "Interviewee" == name)
        return (OpenXmlElement) new Interviewee();
      if (9 == (int) namespaceId && "Interviewer" == name)
        return (OpenXmlElement) new Interviewer();
      if (9 == (int) namespaceId && "Inventor" == name)
        return (OpenXmlElement) new Inventor();
      if (9 == (int) namespaceId && "Performer" == name)
        return (OpenXmlElement) new Performer();
      if (9 == (int) namespaceId && "ProducerName" == name)
        return (OpenXmlElement) new ProducerName();
      if (9 == (int) namespaceId && "Translator" == name)
        return (OpenXmlElement) new Translator();
      if (9 == (int) namespaceId && "Writer" == name)
        return (OpenXmlElement) new Writer();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AuthorList.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AuthorList.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public Artist Artist
    {
      get
      {
        return this.GetElement<Artist>(0);
      }
      set
      {
        this.SetElement<Artist>(0, value);
      }
    }

    public Author Author
    {
      get
      {
        return this.GetElement<Author>(1);
      }
      set
      {
        this.SetElement<Author>(1, value);
      }
    }

    public BookAuthor BookAuthor
    {
      get
      {
        return this.GetElement<BookAuthor>(2);
      }
      set
      {
        this.SetElement<BookAuthor>(2, value);
      }
    }

    public DocumentFormat.OpenXml.Bibliography.Compiler Compiler
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Bibliography.Compiler>(3);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Bibliography.Compiler>(3, value);
      }
    }

    public Composer Composer
    {
      get
      {
        return this.GetElement<Composer>(4);
      }
      set
      {
        this.SetElement<Composer>(4, value);
      }
    }

    public Conductor Conductor
    {
      get
      {
        return this.GetElement<Conductor>(5);
      }
      set
      {
        this.SetElement<Conductor>(5, value);
      }
    }

    public Counsel Counsel
    {
      get
      {
        return this.GetElement<Counsel>(6);
      }
      set
      {
        this.SetElement<Counsel>(6, value);
      }
    }

    public Director Director
    {
      get
      {
        return this.GetElement<Director>(7);
      }
      set
      {
        this.SetElement<Director>(7, value);
      }
    }

    public Editor Editor
    {
      get
      {
        return this.GetElement<Editor>(8);
      }
      set
      {
        this.SetElement<Editor>(8, value);
      }
    }

    public Interviewee Interviewee
    {
      get
      {
        return this.GetElement<Interviewee>(9);
      }
      set
      {
        this.SetElement<Interviewee>(9, value);
      }
    }

    public Interviewer Interviewer
    {
      get
      {
        return this.GetElement<Interviewer>(10);
      }
      set
      {
        this.SetElement<Interviewer>(10, value);
      }
    }

    public Inventor Inventor
    {
      get
      {
        return this.GetElement<Inventor>(11);
      }
      set
      {
        this.SetElement<Inventor>(11, value);
      }
    }

    public Performer Performer
    {
      get
      {
        return this.GetElement<Performer>(12);
      }
      set
      {
        this.SetElement<Performer>(12, value);
      }
    }

    public ProducerName ProducerName
    {
      get
      {
        return this.GetElement<ProducerName>(13);
      }
      set
      {
        this.SetElement<ProducerName>(13, value);
      }
    }

    public Translator Translator
    {
      get
      {
        return this.GetElement<Translator>(14);
      }
      set
      {
        this.SetElement<Translator>(14, value);
      }
    }

    public Writer Writer
    {
      get
      {
        return this.GetElement<Writer>(15);
      }
      set
      {
        this.SetElement<Writer>(15, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AuthorList>(deep);
    }
  }
}
