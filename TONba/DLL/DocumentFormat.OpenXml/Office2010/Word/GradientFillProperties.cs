// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (PathShadeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GradientStopList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LinearShadeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class GradientFillProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "gsLst",
      "lin",
      "path"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "gradFill";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12915;

    public override string LocalName
    {
      get
      {
        return "gradFill";
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
        return 12915;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GradientFillProperties()
    {
    }

    public GradientFillProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GradientFillProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GradientFillProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "gsLst" == name)
        return (OpenXmlElement) new GradientStopList();
      if (52 == (int) namespaceId && "lin" == name)
        return (OpenXmlElement) new LinearShadeProperties();
      if (52 == (int) namespaceId && "path" == name)
        return (OpenXmlElement) new PathShadeProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GradientFillProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GradientFillProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GradientStopList GradientStopList
    {
      get
      {
        return this.GetElement<GradientStopList>(0);
      }
      set
      {
        this.SetElement<GradientStopList>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GradientFillProperties>(deep);
    }
  }
}
