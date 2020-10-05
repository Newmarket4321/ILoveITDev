// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Iterate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TimeAbsolute))]
  [ChildElementInfo(typeof (TimePercentage))]
  [GeneratedCode("DomGen", "2.0")]
  public class Iterate : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "type",
      "backwards"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[2]
    {
      "tmAbs",
      "tmPct"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "iterate";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12400;

    public override string LocalName
    {
      get
      {
        return "iterate";
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
        return 12400;
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
        return Iterate.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Iterate.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<IterateValues> Type
    {
      get
      {
        return (EnumValue<IterateValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "backwards")]
    public BooleanValue Backwards
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

    public Iterate()
    {
    }

    public Iterate(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Iterate(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Iterate(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tmAbs" == name)
        return (OpenXmlElement) new TimeAbsolute();
      if (24 == (int) namespaceId && "tmPct" == name)
        return (OpenXmlElement) new TimePercentage();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Iterate.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Iterate.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public TimeAbsolute TimeAbsolute
    {
      get
      {
        return this.GetElement<TimeAbsolute>(0);
      }
      set
      {
        this.SetElement<TimeAbsolute>(0, value);
      }
    }

    public TimePercentage TimePercentage
    {
      get
      {
        return this.GetElement<TimePercentage>(1);
      }
      set
      {
        this.SetElement<TimePercentage>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<IterateValues>();
      if ((int) namespaceId == 0 && "backwards" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Iterate>(deep);
    }
  }
}
