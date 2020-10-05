// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [ChildElementInfo(typeof (ImageLayer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class ImageProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "imgLayer"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 48
    };
    private const string tagName = "imgProps";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12791;

    public override string LocalName
    {
      get
      {
        return "imgProps";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12791;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ImageProperties()
    {
    }

    public ImageProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ImageProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ImageProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "imgLayer" == name)
        return (OpenXmlElement) new ImageLayer();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ImageProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ImageProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ImageLayer ImageLayer
    {
      get
      {
        return this.GetElement<ImageLayer>(0);
      }
      set
      {
        this.SetElement<ImageLayer>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ImageProperties>(deep);
    }
  }
}
