// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ImageEffect), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ImageLayer : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "embed"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 19
    };
    private const string tagName = "imgLayer";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12826;

    public override string LocalName
    {
      get
      {
        return "imgLayer";
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
        return 12826;
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
        return ImageLayer.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ImageLayer.attributeNamespaceIds;
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

    public ImageLayer()
    {
    }

    public ImageLayer(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ImageLayer(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ImageLayer(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "imgEffect" == name)
        return (OpenXmlElement) new ImageEffect();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "embed" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ImageLayer>(deep);
    }
  }
}
