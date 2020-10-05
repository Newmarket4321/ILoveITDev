// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.GradientStop
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RgbColorModelHex), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SchemeColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class GradientStop : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "pos"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "srgbClr",
      "schemeClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "gs";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12943;

    public override string LocalName
    {
      get
      {
        return "gs";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12943;
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
        return GradientStop.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GradientStop.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "pos")]
    public Int32Value StopPosition
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public GradientStop()
    {
    }

    public GradientStop(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GradientStop(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GradientStop(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "srgbClr" == name)
        return (OpenXmlElement) new RgbColorModelHex();
      if (52 == (int) namespaceId && "schemeClr" == name)
        return (OpenXmlElement) new SchemeColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GradientStop.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GradientStop.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public RgbColorModelHex RgbColorModelHex
    {
      get
      {
        return this.GetElement<RgbColorModelHex>(0);
      }
      set
      {
        this.SetElement<RgbColorModelHex>(0, value);
      }
    }

    public SchemeColor SchemeColor
    {
      get
      {
        return this.GetElement<SchemeColor>(1);
      }
      set
      {
        this.SetElement<SchemeColor>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "pos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GradientStop>(deep);
    }
  }
}
