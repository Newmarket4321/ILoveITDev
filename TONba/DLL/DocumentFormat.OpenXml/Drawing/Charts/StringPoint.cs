// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.StringPoint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (NumericValue))]
  [GeneratedCode("DomGen", "2.0")]
  public class StringPoint : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "idx"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "v"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 11
    };
    private const string tagName = "pt";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10532;

    public override string LocalName
    {
      get
      {
        return "pt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10532;
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
        return StringPoint.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StringPoint.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public StringPoint()
    {
    }

    public StringPoint(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StringPoint(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StringPoint(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "v" == name)
        return (OpenXmlElement) new NumericValue();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StringPoint.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StringPoint.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NumericValue NumericValue
    {
      get
      {
        return this.GetElement<NumericValue>(0);
      }
      set
      {
        this.SetElement<NumericValue>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "idx" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StringPoint>(deep);
    }
  }
}
