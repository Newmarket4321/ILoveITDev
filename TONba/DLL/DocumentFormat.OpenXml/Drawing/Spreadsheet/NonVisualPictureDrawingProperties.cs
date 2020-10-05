// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [ChildElementInfo(typeof (NonVisualPicturePropertiesExtensionList))]
  [ChildElementInfo(typeof (PictureLocks))]
  [GeneratedCode("DomGen", "2.0")]
  public class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "preferRelativeResize"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "picLocks",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvPicPr";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10817;

    public override string LocalName
    {
      get
      {
        return "cNvPicPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10817;
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
        return NonVisualPictureDrawingProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NonVisualPictureDrawingProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "preferRelativeResize")]
    public BooleanValue PreferRelativeResize
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

    public NonVisualPictureDrawingProperties()
    {
    }

    public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualPictureDrawingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "picLocks" == name)
        return (OpenXmlElement) new PictureLocks();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new NonVisualPicturePropertiesExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualPictureDrawingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualPictureDrawingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PictureLocks PictureLocks
    {
      get
      {
        return this.GetElement<PictureLocks>(0);
      }
      set
      {
        this.SetElement<PictureLocks>(0, value);
      }
    }

    public NonVisualPicturePropertiesExtensionList NonVisualPicturePropertiesExtensionList
    {
      get
      {
        return this.GetElement<NonVisualPicturePropertiesExtensionList>(1);
      }
      set
      {
        this.SetElement<NonVisualPicturePropertiesExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "preferRelativeResize" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualPictureDrawingProperties>(deep);
    }
  }
}
