﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TextListStyleType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Level2ParagraphProperties))]
  [ChildElementInfo(typeof (Level9ParagraphProperties))]
  [ChildElementInfo(typeof (Level4ParagraphProperties))]
  [ChildElementInfo(typeof (Level5ParagraphProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DefaultParagraphProperties))]
  [ChildElementInfo(typeof (Level1ParagraphProperties))]
  [ChildElementInfo(typeof (Level3ParagraphProperties))]
  [ChildElementInfo(typeof (Level6ParagraphProperties))]
  [ChildElementInfo(typeof (Level7ParagraphProperties))]
  [ChildElementInfo(typeof (Level8ParagraphProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.ExtensionList))]
  public abstract class TextListStyleType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[11]
    {
      "defPPr",
      "lvl1pPr",
      "lvl2pPr",
      "lvl3pPr",
      "lvl4pPr",
      "lvl5pPr",
      "lvl6pPr",
      "lvl7pPr",
      "lvl8pPr",
      "lvl9pPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "defPPr" == name)
        return (OpenXmlElement) new DefaultParagraphProperties();
      if (10 == (int) namespaceId && "lvl1pPr" == name)
        return (OpenXmlElement) new Level1ParagraphProperties();
      if (10 == (int) namespaceId && "lvl2pPr" == name)
        return (OpenXmlElement) new Level2ParagraphProperties();
      if (10 == (int) namespaceId && "lvl3pPr" == name)
        return (OpenXmlElement) new Level3ParagraphProperties();
      if (10 == (int) namespaceId && "lvl4pPr" == name)
        return (OpenXmlElement) new Level4ParagraphProperties();
      if (10 == (int) namespaceId && "lvl5pPr" == name)
        return (OpenXmlElement) new Level5ParagraphProperties();
      if (10 == (int) namespaceId && "lvl6pPr" == name)
        return (OpenXmlElement) new Level6ParagraphProperties();
      if (10 == (int) namespaceId && "lvl7pPr" == name)
        return (OpenXmlElement) new Level7ParagraphProperties();
      if (10 == (int) namespaceId && "lvl8pPr" == name)
        return (OpenXmlElement) new Level8ParagraphProperties();
      if (10 == (int) namespaceId && "lvl9pPr" == name)
        return (OpenXmlElement) new Level9ParagraphProperties();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextListStyleType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextListStyleType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DefaultParagraphProperties DefaultParagraphProperties
    {
      get
      {
        return this.GetElement<DefaultParagraphProperties>(0);
      }
      set
      {
        this.SetElement<DefaultParagraphProperties>(0, value);
      }
    }

    public Level1ParagraphProperties Level1ParagraphProperties
    {
      get
      {
        return this.GetElement<Level1ParagraphProperties>(1);
      }
      set
      {
        this.SetElement<Level1ParagraphProperties>(1, value);
      }
    }

    public Level2ParagraphProperties Level2ParagraphProperties
    {
      get
      {
        return this.GetElement<Level2ParagraphProperties>(2);
      }
      set
      {
        this.SetElement<Level2ParagraphProperties>(2, value);
      }
    }

    public Level3ParagraphProperties Level3ParagraphProperties
    {
      get
      {
        return this.GetElement<Level3ParagraphProperties>(3);
      }
      set
      {
        this.SetElement<Level3ParagraphProperties>(3, value);
      }
    }

    public Level4ParagraphProperties Level4ParagraphProperties
    {
      get
      {
        return this.GetElement<Level4ParagraphProperties>(4);
      }
      set
      {
        this.SetElement<Level4ParagraphProperties>(4, value);
      }
    }

    public Level5ParagraphProperties Level5ParagraphProperties
    {
      get
      {
        return this.GetElement<Level5ParagraphProperties>(5);
      }
      set
      {
        this.SetElement<Level5ParagraphProperties>(5, value);
      }
    }

    public Level6ParagraphProperties Level6ParagraphProperties
    {
      get
      {
        return this.GetElement<Level6ParagraphProperties>(6);
      }
      set
      {
        this.SetElement<Level6ParagraphProperties>(6, value);
      }
    }

    public Level7ParagraphProperties Level7ParagraphProperties
    {
      get
      {
        return this.GetElement<Level7ParagraphProperties>(7);
      }
      set
      {
        this.SetElement<Level7ParagraphProperties>(7, value);
      }
    }

    public Level8ParagraphProperties Level8ParagraphProperties
    {
      get
      {
        return this.GetElement<Level8ParagraphProperties>(8);
      }
      set
      {
        this.SetElement<Level8ParagraphProperties>(8, value);
      }
    }

    public Level9ParagraphProperties Level9ParagraphProperties
    {
      get
      {
        return this.GetElement<Level9ParagraphProperties>(9);
      }
      set
      {
        this.SetElement<Level9ParagraphProperties>(9, value);
      }
    }

    public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(10);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(10, value);
      }
    }

    protected TextListStyleType()
    {
    }

    protected TextListStyleType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TextListStyleType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TextListStyleType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
