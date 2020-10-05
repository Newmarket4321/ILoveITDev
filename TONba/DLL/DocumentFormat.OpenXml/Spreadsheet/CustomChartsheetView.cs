// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CustomChartsheetView
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ChartSheetPageSetup))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (PageMargins))]
  public class CustomChartsheetView : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "guid",
      "scale",
      "state",
      "zoomToFit"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[3]
    {
      "pageMargins",
      "pageSetup",
      "headerFooter"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "customSheetView";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11275;

    public override string LocalName
    {
      get
      {
        return "customSheetView";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11275;
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
        return CustomChartsheetView.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CustomChartsheetView.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "guid")]
    public StringValue Guid
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "scale")]
    public UInt32Value Scale
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "state")]
    public EnumValue<SheetStateValues> State
    {
      get
      {
        return (EnumValue<SheetStateValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoomToFit")]
    public BooleanValue ZoomToFit
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public CustomChartsheetView()
    {
    }

    public CustomChartsheetView(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomChartsheetView(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomChartsheetView(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (22 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new ChartSheetPageSetup();
      if (22 == (int) namespaceId && "headerFooter" == name)
        return (OpenXmlElement) new HeaderFooter();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomChartsheetView.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomChartsheetView.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PageMargins PageMargins
    {
      get
      {
        return this.GetElement<PageMargins>(0);
      }
      set
      {
        this.SetElement<PageMargins>(0, value);
      }
    }

    public ChartSheetPageSetup ChartSheetPageSetup
    {
      get
      {
        return this.GetElement<ChartSheetPageSetup>(1);
      }
      set
      {
        this.SetElement<ChartSheetPageSetup>(1, value);
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(2);
      }
      set
      {
        this.SetElement<HeaderFooter>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "guid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "scale" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "state" == name)
        return (OpenXmlSimpleType) new EnumValue<SheetStateValues>();
      if ((int) namespaceId == 0 && "zoomToFit" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomChartsheetView>(deep);
    }
  }
}
