// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (PercentageHeight), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class RelativeHeight : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "relativeFrom"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "pctHeight"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 51
    };
    private const string tagName = "sizeRelV";
    private const byte tagNsId = 51;
    internal const int ElementTypeIdConst = 12892;

    public override string LocalName
    {
      get
      {
        return "sizeRelV";
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
        return 12892;
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
        return RelativeHeight.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RelativeHeight.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<SizeRelativeVerticallyValues> RelativeFrom
    {
      get
      {
        return (EnumValue<SizeRelativeVerticallyValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public RelativeHeight()
    {
    }

    public RelativeHeight(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RelativeHeight(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RelativeHeight(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (51 == (int) namespaceId && "pctHeight" == name)
        return (OpenXmlElement) new PercentageHeight();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RelativeHeight.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RelativeHeight.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PercentageHeight PercentageHeight
    {
      get
      {
        return this.GetElement<PercentageHeight>(0);
      }
      set
      {
        this.SetElement<PercentageHeight>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "relativeFrom" == name)
        return (OpenXmlSimpleType) new EnumValue<SizeRelativeVerticallyValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RelativeHeight>(deep);
    }
  }
}
