// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Canvas
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TraceFormat))]
  public class Canvas : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "traceFormatRef"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 1,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "traceFormat"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 43
    };
    private const string tagName = "canvas";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12731;

    public override string LocalName
    {
      get
      {
        return "canvas";
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
        return 12731;
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
        return Canvas.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Canvas.attributeNamespaceIds;
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

    [SchemaAttr(0, "traceFormatRef")]
    public StringValue TraceFormatRef
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

    public Canvas()
    {
    }

    public Canvas(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Canvas(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Canvas(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "traceFormat" == name)
        return (OpenXmlElement) new TraceFormat();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Canvas.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Canvas.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TraceFormat TraceFormat
    {
      get
      {
        return this.GetElement<TraceFormat>(0);
      }
      set
      {
        this.SetElement<TraceFormat>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "traceFormatRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Canvas>(deep);
    }
  }
}
