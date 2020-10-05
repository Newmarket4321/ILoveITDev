// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (DataModel))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class SampleDataType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "useDef"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "dataModel"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 14
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return SampleDataType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SampleDataType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "useDef")]
    public BooleanValue UseDefault
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "dataModel" == name)
        return (OpenXmlElement) new DataModel();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SampleDataType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SampleDataType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DataModel DataModel
    {
      get
      {
        return this.GetElement<DataModel>(0);
      }
      set
      {
        this.SetElement<DataModel>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "useDef" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected SampleDataType()
    {
    }

    protected SampleDataType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected SampleDataType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected SampleDataType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
