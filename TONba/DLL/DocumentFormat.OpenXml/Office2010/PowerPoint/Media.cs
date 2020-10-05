// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.Media
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (MediaTrim), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MediaFade), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MediaBookmarkList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Media : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "embed",
      "link"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 19,
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "trim",
      "fade",
      "bmkLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 49,
      (byte) 49,
      (byte) 49,
      (byte) 49
    };
    private const string tagName = "media";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12834;

    public override string LocalName
    {
      get
      {
        return "media";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12834;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Media.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Media.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "embed")]
    public StringValue Embed
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "link")]
    public StringValue Link
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public Media()
    {
    }

    public Media(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Media(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Media(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "trim" == name)
        return (OpenXmlElement) new MediaTrim();
      if (49 == (int) namespaceId && "fade" == name)
        return (OpenXmlElement) new MediaFade();
      if (49 == (int) namespaceId && "bmkLst" == name)
        return (OpenXmlElement) new MediaBookmarkList();
      if (49 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Media.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Media.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MediaTrim MediaTrim
    {
      get
      {
        return this.GetElement<MediaTrim>(0);
      }
      set
      {
        this.SetElement<MediaTrim>(0, value);
      }
    }

    public MediaFade MediaFade
    {
      get
      {
        return this.GetElement<MediaFade>(1);
      }
      set
      {
        this.SetElement<MediaFade>(1, value);
      }
    }

    public MediaBookmarkList MediaBookmarkList
    {
      get
      {
        return this.GetElement<MediaBookmarkList>(2);
      }
      set
      {
        this.SetElement<MediaBookmarkList>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "embed" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "link" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Media>(deep);
    }
  }
}
