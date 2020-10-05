// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [ChildElementInfo(typeof (HorizontalAlignment))]
  [ChildElementInfo(typeof (PercentagePositionHeightOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PositionOffset))]
  public class HorizontalPosition : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "relativeFrom"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "align",
      "posOffset",
      "pctPosHOffset"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 16,
      (byte) 16,
      (byte) 51
    };
    private const string tagName = "positionH";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10772;

    public override string LocalName
    {
      get
      {
        return "positionH";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 16;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10772;
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
        return HorizontalPosition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HorizontalPosition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<HorizontalRelativePositionValues> RelativeFrom
    {
      get
      {
        return (EnumValue<HorizontalRelativePositionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public HorizontalPosition()
    {
    }

    public HorizontalPosition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HorizontalPosition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HorizontalPosition(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "align" == name)
        return (OpenXmlElement) new HorizontalAlignment();
      if (16 == (int) namespaceId && "posOffset" == name)
        return (OpenXmlElement) new PositionOffset();
      if (51 == (int) namespaceId && "pctPosHOffset" == name)
        return (OpenXmlElement) new PercentagePositionHeightOffset();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HorizontalPosition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HorizontalPosition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public HorizontalAlignment HorizontalAlignment
    {
      get
      {
        return this.GetElement<HorizontalAlignment>(0);
      }
      set
      {
        this.SetElement<HorizontalAlignment>(0, value);
      }
    }

    public PositionOffset PositionOffset
    {
      get
      {
        return this.GetElement<PositionOffset>(1);
      }
      set
      {
        this.SetElement<PositionOffset>(1, value);
      }
    }

    public PercentagePositionHeightOffset PercentagePositionHeightOffset
    {
      get
      {
        return this.GetElement<PercentagePositionHeightOffset>(2);
      }
      set
      {
        this.SetElement<PercentagePositionHeightOffset>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "relativeFrom" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalRelativePositionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HorizontalPosition>(deep);
    }
  }
}
