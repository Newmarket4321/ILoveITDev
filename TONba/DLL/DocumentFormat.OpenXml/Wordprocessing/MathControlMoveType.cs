// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DeletedMathControl))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunProperties))]
  [ChildElementInfo(typeof (InsertedMathControl))]
  public abstract class MathControlMoveType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "author",
      "date",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return MathControlMoveType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MathControlMoveType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "author")]
    public StringValue Author
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

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public StringValue Id
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new InsertedMathControl();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new DeletedMathControl();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected MathControlMoveType()
    {
    }

    protected MathControlMoveType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected MathControlMoveType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected MathControlMoveType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
