// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class ApplicationNonVisualDrawingProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "macro",
      "fPublished"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "nvPr";
    private const byte tagNsId = 47;
    internal const int ElementTypeIdConst = 12778;

    public override string LocalName
    {
      get
      {
        return "nvPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 47;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12778;
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
        return ApplicationNonVisualDrawingProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ApplicationNonVisualDrawingProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "macro")]
    public StringValue Macro
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

    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fPublished" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ApplicationNonVisualDrawingProperties>(deep);
    }
  }
}
