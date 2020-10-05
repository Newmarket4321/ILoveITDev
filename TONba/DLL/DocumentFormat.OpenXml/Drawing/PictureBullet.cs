// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.PictureBullet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Blip))]
  [GeneratedCode("DomGen", "2.0")]
  public class PictureBullet : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "blip"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "buBlip";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10112;

    public override string LocalName
    {
      get
      {
        return "buBlip";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10112;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PictureBullet()
    {
    }

    public PictureBullet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PictureBullet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PictureBullet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "blip" == name)
        return (OpenXmlElement) new Blip();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PictureBullet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PictureBullet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Blip Blip
    {
      get
      {
        return this.GetElement<Blip>(0);
      }
      set
      {
        this.SetElement<Blip>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PictureBullet>(deep);
    }
  }
}
