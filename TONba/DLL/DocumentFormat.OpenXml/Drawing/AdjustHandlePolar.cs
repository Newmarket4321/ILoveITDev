// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.AdjustHandlePolar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Position))]
  [GeneratedCode("DomGen", "2.0")]
  public class AdjustHandlePolar : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "gdRefR",
      "minR",
      "maxR",
      "gdRefAng",
      "minAng",
      "maxAng"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private static readonly string[] eleTagNames = new string[1]
    {
      "pos"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "ahPolar";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10216;

    public override string LocalName
    {
      get
      {
        return "ahPolar";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10216;
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
        return AdjustHandlePolar.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AdjustHandlePolar.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "gdRefR")]
    public StringValue RadialAdjustmentGuide
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

    [SchemaAttr(0, "minR")]
    public StringValue MinRadial
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

    [SchemaAttr(0, "maxR")]
    public StringValue MaxRadial
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

    [SchemaAttr(0, "gdRefAng")]
    public StringValue AngleAdjustmentGuide
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minAng")]
    public StringValue MinAngle
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxAng")]
    public StringValue MaxAngle
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public AdjustHandlePolar()
    {
    }

    public AdjustHandlePolar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AdjustHandlePolar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AdjustHandlePolar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new Position();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AdjustHandlePolar.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AdjustHandlePolar.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(0);
      }
      set
      {
        this.SetElement<Position>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "gdRefR" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "minR" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "maxR" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "gdRefAng" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "minAng" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "maxAng" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AdjustHandlePolar>(deep);
    }
  }
}
