// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.PresetTransition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class PresetTransition : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "prst",
      "invX",
      "invY"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "prstTrans";
    private const byte tagNsId = 68;
    internal const int ElementTypeIdConst = 13325;

    public override string LocalName
    {
      get
      {
        return "prstTrans";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 68;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13325;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return PresetTransition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PresetTransition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prst")]
    public StringValue Preset
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

    [SchemaAttr(0, "invX")]
    public BooleanValue InvX
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

    [SchemaAttr(0, "invY")]
    public BooleanValue InvY
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prst" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "invX" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "invY" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresetTransition>(deep);
    }
  }
}
