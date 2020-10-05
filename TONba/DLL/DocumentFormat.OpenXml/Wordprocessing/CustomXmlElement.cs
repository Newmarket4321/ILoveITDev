// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.CustomXmlElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  public abstract class CustomXmlElement : OpenXmlCompositeElement
  {
    protected CustomXmlElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected CustomXmlElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected CustomXmlElement(string outerXml)
      : base(outerXml)
    {
    }

    [SchemaAttr(23, "uri")]
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

    [SchemaAttr(23, "element")]
    public StringValue Element
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "element" == name)
        return (OpenXmlSimpleType) new StringValue();
      return (OpenXmlSimpleType) null;
    }

    public CustomXmlProperties CustomXmlProperties
    {
      get
      {
        return this.GetElement<CustomXmlProperties>(0);
      }
      set
      {
        this.SetElement<CustomXmlProperties>(0, value);
      }
    }
  }
}
