// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (WaveAudioFile))]
  [ChildElementInfo(typeof (VideoFromFile))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PlaceholderShape))]
  [ChildElementInfo(typeof (AudioFromCD))]
  [ChildElementInfo(typeof (AudioFromFile))]
  [ChildElementInfo(typeof (QuickTimeFromFile))]
  [ChildElementInfo(typeof (CustomerDataList))]
  [ChildElementInfo(typeof (ApplicationNonVisualDrawingPropertiesExtensionList))]
  public class ApplicationNonVisualDrawingProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "isPhoto",
      "userDrawn"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[8]
    {
      "ph",
      "audioCd",
      "wavAudioFile",
      "audioFile",
      "videoFile",
      "quickTimeFile",
      "custDataLst",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 24,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "nvPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12325;

    public override string LocalName
    {
      get
      {
        return "nvPr";
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
        return 12325;
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
        return ApplicationNonVisualDrawingProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ApplicationNonVisualDrawingProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "isPhoto")]
    public BooleanValue IsPhoto
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "userDrawn")]
    public BooleanValue UserDrawn
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public ApplicationNonVisualDrawingProperties()
    {
    }

    public ApplicationNonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ApplicationNonVisualDrawingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ApplicationNonVisualDrawingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "ph" == name)
        return (OpenXmlElement) new PlaceholderShape();
      if (10 == (int) namespaceId && "audioCd" == name)
        return (OpenXmlElement) new AudioFromCD();
      if (10 == (int) namespaceId && "wavAudioFile" == name)
        return (OpenXmlElement) new WaveAudioFile();
      if (10 == (int) namespaceId && "audioFile" == name)
        return (OpenXmlElement) new AudioFromFile();
      if (10 == (int) namespaceId && "videoFile" == name)
        return (OpenXmlElement) new VideoFromFile();
      if (10 == (int) namespaceId && "quickTimeFile" == name)
        return (OpenXmlElement) new QuickTimeFromFile();
      if (24 == (int) namespaceId && "custDataLst" == name)
        return (OpenXmlElement) new CustomerDataList();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ApplicationNonVisualDrawingPropertiesExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ApplicationNonVisualDrawingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ApplicationNonVisualDrawingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PlaceholderShape PlaceholderShape
    {
      get
      {
        return this.GetElement<PlaceholderShape>(0);
      }
      set
      {
        this.SetElement<PlaceholderShape>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "isPhoto" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "userDrawn" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ApplicationNonVisualDrawingProperties>(deep);
    }
  }
}
