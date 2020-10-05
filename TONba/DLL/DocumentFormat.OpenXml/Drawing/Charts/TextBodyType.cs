// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.TextBodyType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ListStyle))]
  [ChildElementInfo(typeof (BodyProperties))]
  [ChildElementInfo(typeof (Paragraph))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class TextBodyType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "bodyPr",
      "lstStyle",
      "p"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "bodyPr" == name)
        return (OpenXmlElement) new BodyProperties();
      if (10 == (int) namespaceId && "lstStyle" == name)
        return (OpenXmlElement) new ListStyle();
      if (10 == (int) namespaceId && "p" == name)
        return (OpenXmlElement) new Paragraph();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextBodyType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextBodyType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BodyProperties BodyProperties
    {
      get
      {
        return this.GetElement<BodyProperties>(0);
      }
      set
      {
        this.SetElement<BodyProperties>(0, value);
      }
    }

    public ListStyle ListStyle
    {
      get
      {
        return this.GetElement<ListStyle>(1);
      }
      set
      {
        this.SetElement<ListStyle>(1, value);
      }
    }

    protected TextBodyType()
    {
    }

    protected TextBodyType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TextBodyType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TextBodyType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
