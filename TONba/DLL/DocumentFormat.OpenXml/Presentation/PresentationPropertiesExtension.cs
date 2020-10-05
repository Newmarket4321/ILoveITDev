// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.PresentationPropertiesExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.PowerPoint;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (DefaultImageDpi), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TextMath), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DiscardImageEditData), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ChartTrackingReferenceBased), FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class PresentationPropertiesExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12432;

    public override string LocalName
    {
      get
      {
        return "ext";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12432;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return PresentationPropertiesExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PresentationPropertiesExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public PresentationPropertiesExtension()
    {
    }

    public PresentationPropertiesExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PresentationPropertiesExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PresentationPropertiesExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "discardImageEditData" == name)
        return (OpenXmlElement) new DiscardImageEditData();
      if (49 == (int) namespaceId && "defaultImageDpi" == name)
        return (OpenXmlElement) new DefaultImageDpi();
      if (48 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new TextMath();
      if (68 == (int) namespaceId && "chartTrackingRefBased" == name)
        return (OpenXmlElement) new ChartTrackingReferenceBased();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresentationPropertiesExtension>(deep);
    }
  }
}
