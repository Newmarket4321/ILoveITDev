// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LineNumberType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class LineNumberType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "countBy",
      "start",
      "distance",
      "restart"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "lnNumType";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11743;

    public override string LocalName
    {
      get
      {
        return "lnNumType";
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
        return 11743;
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
        return LineNumberType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LineNumberType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "countBy")]
    public Int16Value CountBy
    {
      get
      {
        return (Int16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "start")]
    public Int16Value Start
    {
      get
      {
        return (Int16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "distance")]
    public StringValue Distance
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

    [SchemaAttr(23, "restart")]
    public EnumValue<LineNumberRestartValues> Restart
    {
      get
      {
        return (EnumValue<LineNumberRestartValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "countBy" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "distance" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "restart" == name)
        return (OpenXmlSimpleType) new EnumValue<LineNumberRestartValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LineNumberType>(deep);
    }
  }
}
