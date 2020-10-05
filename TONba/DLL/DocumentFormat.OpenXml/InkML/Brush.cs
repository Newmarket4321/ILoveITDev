// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Brush
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
  [ChildElementInfo(typeof (BrushProperty))]
  public class Brush : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "brushRef"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 1,
      (byte) 0
    };
    private const string tagName = "brush";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12734;

    public override string LocalName
    {
      get
      {
        return "brush";
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
        return 12734;
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
        return Brush.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Brush.attributeNamespaceIds;
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

    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
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

    public Brush()
    {
    }

    public Brush(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Brush(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Brush(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "annotation" == name)
        return (OpenXmlElement) new Annotation();
      if (43 == (int) namespaceId && "annotationXML" == name)
        return (OpenXmlElement) new AnnotationXml();
      if (43 == (int) namespaceId && "brushProperty" == name)
        return (OpenXmlElement) new BrushProperty();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "brushRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Brush>(deep);
    }
  }
}
