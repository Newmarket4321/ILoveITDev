// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class SpacingBetweenLines : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "before",
      "beforeLines",
      "beforeAutospacing",
      "after",
      "afterLines",
      "afterAutospacing",
      "line",
      "lineRule"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "spacing";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11577;

    public override string LocalName
    {
      get
      {
        return "spacing";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11577;
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
        return SpacingBetweenLines.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SpacingBetweenLines.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "before")]
    public StringValue Before
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

    [SchemaAttr(23, "beforeLines")]
    public Int32Value BeforeLines
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "beforeAutospacing")]
    public OnOffValue BeforeAutoSpacing
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "after")]
    public StringValue After
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "afterLines")]
    public Int32Value AfterLines
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "afterAutospacing")]
    public OnOffValue AfterAutoSpacing
    {
      get
      {
        return (OnOffValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "line")]
    public StringValue Line
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "lineRule")]
    public EnumValue<LineSpacingRuleValues> LineRule
    {
      get
      {
        return (EnumValue<LineSpacingRuleValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "before" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "beforeLines" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "beforeAutospacing" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "after" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "afterLines" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "afterAutospacing" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "line" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "lineRule" == name)
        return (OpenXmlSimpleType) new EnumValue<LineSpacingRuleValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SpacingBetweenLines>(deep);
    }
  }
}
