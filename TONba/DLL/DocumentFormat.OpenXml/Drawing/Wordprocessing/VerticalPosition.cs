// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [ChildElementInfo(typeof (PercentagePositionVerticalOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VerticalAlignment))]
  [ChildElementInfo(typeof (PositionOffset))]
  public class VerticalPosition : OpenXmlCompositeElement
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
      "pctPosVOffset"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 16,
      (byte) 16,
      (byte) 51
    };
    private const string tagName = "positionV";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10773;

    public override string LocalName
    {
      get
      {
        return "positionV";
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
        return 10773;
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
        return VerticalPosition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return VerticalPosition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<VerticalRelativePositionValues> RelativeFrom
    {
      get
      {
        return (EnumValue<VerticalRelativePositionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public VerticalPosition()
    {
    }

    public VerticalPosition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public VerticalPosition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public VerticalPosition(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "align" == name)
        return (OpenXmlElement) new VerticalAlignment();
      if (16 == (int) namespaceId && "posOffset" == name)
        return (OpenXmlElement) new PositionOffset();
      if (51 == (int) namespaceId && "pctPosVOffset" == name)
        return (OpenXmlElement) new PercentagePositionVerticalOffset();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return VerticalPosition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return VerticalPosition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public VerticalAlignment VerticalAlignment
    {
      get
      {
        return this.GetElement<VerticalAlignment>(0);
      }
      set
      {
        this.SetElement<VerticalAlignment>(0, value);
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

    public PercentagePositionVerticalOffset PercentagePositionVerticalOffset
    {
      get
      {
        return this.GetElement<PercentagePositionVerticalOffset>(2);
      }
      set
      {
        this.SetElement<PercentagePositionVerticalOffset>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "relativeFrom" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalRelativePositionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VerticalPosition>(deep);
    }
  }
}
