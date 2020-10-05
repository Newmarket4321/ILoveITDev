// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.PlaceholderShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  public class PlaceholderShape : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "type",
      "orient",
      "sz",
      "idx",
      "hasCustomPrompt"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "ph";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12394;

    public override string LocalName
    {
      get
      {
        return "ph";
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
        return 12394;
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
        return PlaceholderShape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PlaceholderShape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<PlaceholderValues> Type
    {
      get
      {
        return (EnumValue<PlaceholderValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "orient")]
    public EnumValue<DirectionValues> Orientation
    {
      get
      {
        return (EnumValue<DirectionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sz")]
    public EnumValue<PlaceholderSizeValues> Size
    {
      get
      {
        return (EnumValue<PlaceholderSizeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hasCustomPrompt")]
    public BooleanValue HasCustomPrompt
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public PlaceholderShape()
    {
    }

    public PlaceholderShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PlaceholderShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PlaceholderShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PlaceholderShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PlaceholderShape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionListWithModification ExtensionListWithModification
    {
      get
      {
        return this.GetElement<ExtensionListWithModification>(0);
      }
      set
      {
        this.SetElement<ExtensionListWithModification>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<PlaceholderValues>();
      if ((int) namespaceId == 0 && "orient" == name)
        return (OpenXmlSimpleType) new EnumValue<DirectionValues>();
      if ((int) namespaceId == 0 && "sz" == name)
        return (OpenXmlSimpleType) new EnumValue<PlaceholderSizeValues>();
      if ((int) namespaceId == 0 && "idx" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "hasCustomPrompt" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PlaceholderShape>(deep);
    }
  }
}
