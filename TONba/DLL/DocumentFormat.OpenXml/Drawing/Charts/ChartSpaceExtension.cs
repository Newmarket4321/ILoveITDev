// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (PivotOptions), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SketchOptions), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class ChartSpaceExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10651;

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
        return 10651;
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
        return ChartSpaceExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ChartSpaceExtension.attributeNamespaceIds;
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

    public ChartSpaceExtension()
    {
    }

    public ChartSpaceExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChartSpaceExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChartSpaceExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (46 == (int) namespaceId && "pivotOptions" == name)
        return (OpenXmlElement) new PivotOptions();
      if (46 == (int) namespaceId && "sketchOptions" == name)
        return (OpenXmlElement) new SketchOptions();
      if (64 == (int) namespaceId && "pivotSource" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource();
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
      return (OpenXmlElement) this.CloneImp<ChartSpaceExtension>(deep);
    }
  }
}
