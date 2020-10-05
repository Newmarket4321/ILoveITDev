// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ContentPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualContentPartProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionListModify), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ContentPart : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "bwMode",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 49,
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[3]
    {
      "nvContentPartPr",
      "xfrm",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 49,
      (byte) 49,
      (byte) 49
    };
    private const string tagName = "contentPart";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12247;

    public override string LocalName
    {
      get
      {
        return "contentPart";
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
        return 12247;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ContentPart.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContentPart.attributeNamespaceIds;
      }
    }

    [SchemaAttr(49, "bwMode")]
    public EnumValue<BlackWhiteModeValues> BwMode
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public ContentPart()
    {
    }

    public ContentPart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ContentPart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ContentPart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "nvContentPartPr" == name)
        return (OpenXmlElement) new NonVisualContentPartProperties();
      if (49 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D();
      if (49 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListModify();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ContentPart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ContentPart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualContentPartProperties NonVisualContentPartProperties
    {
      get
      {
        return this.GetElement<NonVisualContentPartProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualContentPartProperties>(0, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D Transform2D
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D>(1);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D>(1, value);
      }
    }

    public ExtensionListModify ExtensionListModify
    {
      get
      {
        return this.GetElement<ExtensionListModify>(2);
      }
      set
      {
        this.SetElement<ExtensionListModify>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "bwMode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContentPart>(deep);
    }
  }
}
