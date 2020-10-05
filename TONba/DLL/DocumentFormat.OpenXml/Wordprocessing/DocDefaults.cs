// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DocDefaults
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunPropertiesDefault))]
  [ChildElementInfo(typeof (ParagraphPropertiesDefault))]
  public class DocDefaults : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "rPrDefault",
      "pPrDefault"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "docDefaults";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11960;

    public override string LocalName
    {
      get
      {
        return "docDefaults";
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
        return 11960;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocDefaults()
    {
    }

    public DocDefaults(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocDefaults(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocDefaults(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPrDefault" == name)
        return (OpenXmlElement) new RunPropertiesDefault();
      if (23 == (int) namespaceId && "pPrDefault" == name)
        return (OpenXmlElement) new ParagraphPropertiesDefault();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocDefaults.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocDefaults.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunPropertiesDefault RunPropertiesDefault
    {
      get
      {
        return this.GetElement<RunPropertiesDefault>(0);
      }
      set
      {
        this.SetElement<RunPropertiesDefault>(0, value);
      }
    }

    public ParagraphPropertiesDefault ParagraphPropertiesDefault
    {
      get
      {
        return this.GetElement<ParagraphPropertiesDefault>(1);
      }
      set
      {
        this.SetElement<ParagraphPropertiesDefault>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocDefaults>(deep);
    }
  }
}
