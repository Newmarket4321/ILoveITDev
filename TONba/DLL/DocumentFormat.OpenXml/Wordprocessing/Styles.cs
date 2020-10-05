// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Styles
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocDefaults))]
  [ChildElementInfo(typeof (LatentStyles))]
  [ChildElementInfo(typeof (Style))]
  public class Styles : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "docDefaults",
      "latentStyles",
      "style"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "styles";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11764;

    public override string LocalName
    {
      get
      {
        return "styles";
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
        return 11764;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Styles()
    {
    }

    public Styles(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Styles(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Styles(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "docDefaults" == name)
        return (OpenXmlElement) new DocDefaults();
      if (23 == (int) namespaceId && "latentStyles" == name)
        return (OpenXmlElement) new LatentStyles();
      if (23 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new Style();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Styles.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Styles.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocDefaults DocDefaults
    {
      get
      {
        return this.GetElement<DocDefaults>(0);
      }
      set
      {
        this.SetElement<DocDefaults>(0, value);
      }
    }

    public LatentStyles LatentStyles
    {
      get
      {
        return this.GetElement<LatentStyles>(1);
      }
      set
      {
        this.SetElement<LatentStyles>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Styles>(deep);
    }

    internal Styles(StylesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(StylesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public void Save(StylesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    public StylesPart StylesPart
    {
      get
      {
        return this.OpenXmlPart as StylesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }
  }
}
