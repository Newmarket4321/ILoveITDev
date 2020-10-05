// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Trace
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  public class Trace : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "id",
      "type",
      "continuation",
      "priorRef",
      "contextRef",
      "brushRef",
      "duration",
      "timeOffset"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "trace";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12736;

    public override string LocalName
    {
      get
      {
        return "trace";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12736;
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
        return Trace.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Trace.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "type")]
    public EnumValue<TraceTypeValues> Type
    {
      get
      {
        return (EnumValue<TraceTypeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "continuation")]
    public EnumValue<TraceContinuationValues> Continuation
    {
      get
      {
        return (EnumValue<TraceContinuationValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "priorRef")]
    public StringValue PriorRef
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

    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "duration")]
    public DecimalValue Duration
    {
      get
      {
        return (DecimalValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "timeOffset")]
    public DecimalValue TimeOffset
    {
      get
      {
        return (DecimalValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public Trace()
    {
    }

    public Trace(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<TraceTypeValues>();
      if ((int) namespaceId == 0 && "continuation" == name)
        return (OpenXmlSimpleType) new EnumValue<TraceContinuationValues>();
      if ((int) namespaceId == 0 && "priorRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "contextRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "brushRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "duration" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "timeOffset" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Trace>(deep);
    }
  }
}
