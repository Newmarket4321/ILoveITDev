// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ChartSpace
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EditingLanguage))]
  [ChildElementInfo(typeof (RoundedCorners))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Style))]
  [ChildElementInfo(typeof (ColorMapOverride))]
  [ChildElementInfo(typeof (PivotSource))]
  [ChildElementInfo(typeof (Protection))]
  [ChildElementInfo(typeof (Chart))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (ExternalData))]
  [ChildElementInfo(typeof (PrintSettings))]
  [ChildElementInfo(typeof (UserShapesReference))]
  [ChildElementInfo(typeof (ChartSpaceExtensionList))]
  [ChildElementInfo(typeof (Date1904))]
  public class ChartSpace : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[15]
    {
      "date1904",
      "lang",
      "roundedCorners",
      "style",
      "style",
      "clrMapOvr",
      "pivotSource",
      "protection",
      "chart",
      "spPr",
      "txPr",
      "externalData",
      "printSettings",
      "userShapes",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[15]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 46,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "chartSpace";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10392;

    public override string LocalName
    {
      get
      {
        return "chartSpace";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10392;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal ChartSpace(ChartPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ChartPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ChartPart ChartPart
    {
      get
      {
        return this.OpenXmlPart as ChartPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ChartSpace(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChartSpace(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChartSpace(string outerXml)
      : base(outerXml)
    {
    }

    public ChartSpace()
    {
    }

    public void Save(ChartPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "date1904" == name)
        return (OpenXmlElement) new Date1904();
      if (11 == (int) namespaceId && "lang" == name)
        return (OpenXmlElement) new EditingLanguage();
      if (11 == (int) namespaceId && "roundedCorners" == name)
        return (OpenXmlElement) new RoundedCorners();
      if (46 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style();
      if (11 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new Style();
      if (11 == (int) namespaceId && "clrMapOvr" == name)
        return (OpenXmlElement) new ColorMapOverride();
      if (11 == (int) namespaceId && "pivotSource" == name)
        return (OpenXmlElement) new PivotSource();
      if (11 == (int) namespaceId && "protection" == name)
        return (OpenXmlElement) new Protection();
      if (11 == (int) namespaceId && "chart" == name)
        return (OpenXmlElement) new Chart();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (11 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (11 == (int) namespaceId && "externalData" == name)
        return (OpenXmlElement) new ExternalData();
      if (11 == (int) namespaceId && "printSettings" == name)
        return (OpenXmlElement) new PrintSettings();
      if (11 == (int) namespaceId && "userShapes" == name)
        return (OpenXmlElement) new UserShapesReference();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ChartSpaceExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ChartSpace.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ChartSpace.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Date1904 Date1904
    {
      get
      {
        return this.GetElement<Date1904>(0);
      }
      set
      {
        this.SetElement<Date1904>(0, value);
      }
    }

    public EditingLanguage EditingLanguage
    {
      get
      {
        return this.GetElement<EditingLanguage>(1);
      }
      set
      {
        this.SetElement<EditingLanguage>(1, value);
      }
    }

    public RoundedCorners RoundedCorners
    {
      get
      {
        return this.GetElement<RoundedCorners>(2);
      }
      set
      {
        this.SetElement<RoundedCorners>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ChartSpace>(deep);
    }
  }
}
