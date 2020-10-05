// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.CanvasTransform
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Mapping))]
  [GeneratedCode("DomGen", "2.0")]
  public class CanvasTransform : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "invertible"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 1,
      (byte) 0
    };
    private const string tagName = "canvasTransform";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12732;

    public override string LocalName
    {
      get
      {
        return "canvasTransform";
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
        return 12732;
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
        return CanvasTransform.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CanvasTransform.attributeNamespaceIds;
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

    [SchemaAttr(0, "invertible")]
    public BooleanValue Invertible
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

    public CanvasTransform()
    {
    }

    public CanvasTransform(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CanvasTransform(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CanvasTransform(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "mapping" == name)
        return (OpenXmlElement) new Mapping();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "invertible" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CanvasTransform>(deep);
    }
  }
}
