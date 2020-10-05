// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.BrushProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Annotation))]
  [ChildElementInfo(typeof (AnnotationXml))]
  public class BrushProperty : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "name",
      "value",
      "units"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "brushProperty";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12730;

    public override string LocalName
    {
      get
      {
        return "brushProperty";
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
        return 12730;
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
        return BrushProperty.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BrushProperty.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "value")]
    public StringValue Value
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

    [SchemaAttr(0, "units")]
    public StringValue Units
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

    public BrushProperty()
    {
    }

    public BrushProperty(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BrushProperty(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BrushProperty(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "annotation" == name)
        return (OpenXmlElement) new Annotation();
      if (43 == (int) namespaceId && "annotationXML" == name)
        return (OpenXmlElement) new AnnotationXml();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "value" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "units" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BrushProperty>(deep);
    }
  }
}
