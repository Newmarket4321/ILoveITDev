// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PictureOptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ApplyToEnd))]
  [ChildElementInfo(typeof (ApplyToSides))]
  [ChildElementInfo(typeof (ApplyToFront))]
  [ChildElementInfo(typeof (PictureFormat))]
  [ChildElementInfo(typeof (PictureStackUnit))]
  [GeneratedCode("DomGen", "2.0")]
  public class PictureOptions : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "applyToFront",
      "applyToSides",
      "applyToEnd",
      "pictureFormat",
      "pictureStackUnit"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "pictureOptions";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10435;

    public override string LocalName
    {
      get
      {
        return "pictureOptions";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10435;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PictureOptions()
    {
    }

    public PictureOptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PictureOptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PictureOptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "applyToFront" == name)
        return (OpenXmlElement) new ApplyToFront();
      if (11 == (int) namespaceId && "applyToSides" == name)
        return (OpenXmlElement) new ApplyToSides();
      if (11 == (int) namespaceId && "applyToEnd" == name)
        return (OpenXmlElement) new ApplyToEnd();
      if (11 == (int) namespaceId && "pictureFormat" == name)
        return (OpenXmlElement) new PictureFormat();
      if (11 == (int) namespaceId && "pictureStackUnit" == name)
        return (OpenXmlElement) new PictureStackUnit();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PictureOptions.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PictureOptions.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ApplyToFront ApplyToFront
    {
      get
      {
        return this.GetElement<ApplyToFront>(0);
      }
      set
      {
        this.SetElement<ApplyToFront>(0, value);
      }
    }

    public ApplyToSides ApplyToSides
    {
      get
      {
        return this.GetElement<ApplyToSides>(1);
      }
      set
      {
        this.SetElement<ApplyToSides>(1, value);
      }
    }

    public ApplyToEnd ApplyToEnd
    {
      get
      {
        return this.GetElement<ApplyToEnd>(2);
      }
      set
      {
        this.SetElement<ApplyToEnd>(2, value);
      }
    }

    public PictureFormat PictureFormat
    {
      get
      {
        return this.GetElement<PictureFormat>(3);
      }
      set
      {
        this.SetElement<PictureFormat>(3, value);
      }
    }

    public PictureStackUnit PictureStackUnit
    {
      get
      {
        return this.GetElement<PictureStackUnit>(4);
      }
      set
      {
        this.SetElement<PictureStackUnit>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PictureOptions>(deep);
    }
  }
}
