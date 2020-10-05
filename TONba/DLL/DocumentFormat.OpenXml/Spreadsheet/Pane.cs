// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Pane
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class Pane : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "xSplit",
      "ySplit",
      "topLeftCell",
      "activePane",
      "state"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "pane";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11252;

    public override string LocalName
    {
      get
      {
        return "pane";
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
        return 11252;
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
        return Pane.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Pane.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "xSplit")]
    public DoubleValue HorizontalSplit
    {
      get
      {
        return (DoubleValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ySplit")]
    public DoubleValue VerticalSplit
    {
      get
      {
        return (DoubleValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "topLeftCell")]
    public StringValue TopLeftCell
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "activePane")]
    public EnumValue<PaneValues> ActivePane
    {
      get
      {
        return (EnumValue<PaneValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "state")]
    public EnumValue<PaneStateValues> State
    {
      get
      {
        return (EnumValue<PaneStateValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "xSplit" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "ySplit" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "topLeftCell" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "activePane" == name)
        return (OpenXmlSimpleType) new EnumValue<PaneValues>();
      if ((int) namespaceId == 0 && "state" == name)
        return (OpenXmlSimpleType) new EnumValue<PaneStateValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Pane>(deep);
    }
  }
}
