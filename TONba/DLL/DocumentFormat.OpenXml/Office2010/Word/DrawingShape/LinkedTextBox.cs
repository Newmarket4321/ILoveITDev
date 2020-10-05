// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingShape
{
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class LinkedTextBox : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "seq"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 61
    };
    private const string tagName = "linkedTxbx";
    private const byte tagNsId = 61;
    internal const int ElementTypeIdConst = 13204;

    public override string LocalName
    {
      get
      {
        return "linkedTxbx";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 61;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13204;
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
        return LinkedTextBox.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LinkedTextBox.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt16Value Id
    {
      get
      {
        return (UInt16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "seq")]
    public UInt16Value Sequence
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public LinkedTextBox()
    {
    }

    public LinkedTextBox(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LinkedTextBox(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LinkedTextBox(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (61 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LinkedTextBox.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LinkedTextBox.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(0);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "seq" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LinkedTextBox>(deep);
    }
  }
}
