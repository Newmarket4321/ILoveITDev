// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (RgbColorModelHex), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SchemeColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class SolidColorFillProperties : OpenXmlCompositeElement
  {
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
    private const string tagName = "solidFill";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12914;

    public override string LocalName
    {
      get
      {
        return "solidFill";
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
        return 12914;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SolidColorFillProperties()
    {
    }

    public SolidColorFillProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SolidColorFillProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SolidColorFillProperties(string outerXml)
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
        return SolidColorFillProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SolidColorFillProperties.eleNamespaceIds;
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SolidColorFillProperties>(deep);
    }
  }
}
