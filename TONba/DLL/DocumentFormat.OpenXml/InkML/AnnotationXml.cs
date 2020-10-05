// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.AnnotationXml
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.EMMA;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Emma))]
  [GeneratedCode("DomGen", "2.0")]
  public class AnnotationXml : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "type",
      "encoding",
      "href"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "emma"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 44
    };
    private const string tagName = "annotationXML";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12729;

    public override string LocalName
    {
      get
      {
        return "annotationXML";
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
        return 12729;
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
        return AnnotationXml.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnnotationXml.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public StringValue Type
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

    [SchemaAttr(0, "encoding")]
    public StringValue Encoding
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

    [SchemaAttr(0, "href")]
    public StringValue Href
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

    public AnnotationXml()
    {
    }

    public AnnotationXml(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnnotationXml(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnnotationXml(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "emma" == name)
        return (OpenXmlElement) new Emma();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnnotationXml.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnnotationXml.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Emma Emma
    {
      get
      {
        return this.GetElement<Emma>(0);
      }
      set
      {
        this.SetElement<Emma>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "encoding" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "href" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnnotationXml>(deep);
    }
  }
}
