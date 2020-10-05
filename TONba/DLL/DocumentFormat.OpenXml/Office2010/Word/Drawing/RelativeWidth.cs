// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
  [ChildElementInfo(typeof (PercentageWidth), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class RelativeWidth : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "relativeFrom"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "pctWidth"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 51
    };
    private const string tagName = "sizeRelH";
    private const byte tagNsId = 51;
    internal const int ElementTypeIdConst = 12891;

    public override string LocalName
    {
      get
      {
        return "sizeRelH";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 51;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12891;
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
        return RelativeWidth.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RelativeWidth.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<SizeRelativeHorizontallyValues> ObjectId
    {
      get
      {
        return (EnumValue<SizeRelativeHorizontallyValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public RelativeWidth()
    {
    }

    public RelativeWidth(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RelativeWidth(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RelativeWidth(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (51 == (int) namespaceId && "pctWidth" == name)
        return (OpenXmlElement) new PercentageWidth();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RelativeWidth.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RelativeWidth.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PercentageWidth PercentageWidth
    {
      get
      {
        return this.GetElement<PercentageWidth>(0);
      }
      set
      {
        this.SetElement<PercentageWidth>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "relativeFrom" == name)
        return (OpenXmlSimpleType) new EnumValue<SizeRelativeHorizontallyValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RelativeWidth>(deep);
    }
  }
}
