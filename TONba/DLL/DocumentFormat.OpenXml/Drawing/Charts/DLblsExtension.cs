// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelFieldTable), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShowDataLabelsRange), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class DLblsExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10543;

    public override string LocalName
    {
      get
      {
        return "ext";
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
        return 10543;
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
        return DLblsExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DLblsExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public DLblsExtension()
    {
    }

    public DLblsExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DLblsExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DLblsExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText();
      if (64 == (int) namespaceId && "dlblFieldTable" == name)
        return (OpenXmlElement) new DataLabelFieldTable();
      if (64 == (int) namespaceId && "showDataLabelsRange" == name)
        return (OpenXmlElement) new ShowDataLabelsRange();
      if (64 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties();
      if (64 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout();
      if (64 == (int) namespaceId && "showLeaderLines" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines();
      if (64 == (int) namespaceId && "leaderLines" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DLblsExtension>(deep);
    }
  }
}
