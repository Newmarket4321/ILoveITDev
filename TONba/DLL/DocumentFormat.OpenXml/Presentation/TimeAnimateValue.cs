// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeAnimateValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (VariantValue))]
  [GeneratedCode("DomGen", "2.0")]
  public class TimeAnimateValue : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "tm",
      "fmla"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[1]
    {
      "val"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "tav";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12282;

    public override string LocalName
    {
      get
      {
        return "tav";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12282;
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
        return TimeAnimateValue.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TimeAnimateValue.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "tm")]
    public StringValue Time
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

    [SchemaAttr(0, "fmla")]
    public StringValue Fomula
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

    public TimeAnimateValue()
    {
    }

    public TimeAnimateValue(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimeAnimateValue(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimeAnimateValue(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "val" == name)
        return (OpenXmlElement) new VariantValue();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TimeAnimateValue.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TimeAnimateValue.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public VariantValue VariantValue
    {
      get
      {
        return this.GetElement<VariantValue>(0);
      }
      set
      {
        this.SetElement<VariantValue>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "tm" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fmla" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimeAnimateValue>(deep);
    }
  }
}
