// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Lock
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public class Lock : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "ext",
      "position",
      "selection",
      "grouping",
      "ungrouping",
      "rotation",
      "cropping",
      "verticies",
      "adjusthandles",
      "text",
      "aspectratio",
      "shapetype"
    };
    private static byte[] attributeNamespaceIds = new byte[12]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "lock";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12478;

    public override string LocalName
    {
      get
      {
        return "lock";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12478;
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
        return Lock.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Lock.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "position")]
    public TrueFalseValue Position
    {
      get
      {
        return (TrueFalseValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "selection")]
    public TrueFalseValue Selection
    {
      get
      {
        return (TrueFalseValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "grouping")]
    public TrueFalseValue Grouping
    {
      get
      {
        return (TrueFalseValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ungrouping")]
    public TrueFalseValue Ungrouping
    {
      get
      {
        return (TrueFalseValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotation")]
    public TrueFalseValue Rotation
    {
      get
      {
        return (TrueFalseValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cropping")]
    public TrueFalseValue Cropping
    {
      get
      {
        return (TrueFalseValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "verticies")]
    public TrueFalseValue Verticies
    {
      get
      {
        return (TrueFalseValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "adjusthandles")]
    public TrueFalseValue AdjustHandles
    {
      get
      {
        return (TrueFalseValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "text")]
    public TrueFalseValue TextLock
    {
      get
      {
        return (TrueFalseValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "aspectratio")]
    public TrueFalseValue AspectRatio
    {
      get
      {
        return (TrueFalseValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shapetype")]
    public TrueFalseValue ShapeType
    {
      get
      {
        return (TrueFalseValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "position" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "selection" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "grouping" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "ungrouping" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "rotation" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "cropping" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "verticies" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "adjusthandles" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "text" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "aspectratio" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "shapetype" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Lock>(deep);
    }
  }
}
