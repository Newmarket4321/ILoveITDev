// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ParagraphPropertiesBaseStyle))]
  public class ParagraphPropertiesDefault : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "pPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "pPrDefault";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11895;

    public override string LocalName
    {
      get
      {
        return "pPrDefault";
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
        return 11895;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ParagraphPropertiesDefault()
    {
    }

    public ParagraphPropertiesDefault(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ParagraphPropertiesDefault(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ParagraphPropertiesDefault(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new ParagraphPropertiesBaseStyle();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ParagraphPropertiesDefault.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ParagraphPropertiesDefault.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ParagraphPropertiesBaseStyle ParagraphPropertiesBaseStyle
    {
      get
      {
        return this.GetElement<ParagraphPropertiesBaseStyle>(0);
      }
      set
      {
        this.SetElement<ParagraphPropertiesBaseStyle>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ParagraphPropertiesDefault>(deep);
    }
  }
}
