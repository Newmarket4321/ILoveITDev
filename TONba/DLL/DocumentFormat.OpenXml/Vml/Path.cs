// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Path
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  public class Path : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[15]
    {
      "id",
      "v",
      "limo",
      "textboxrect",
      "fillok",
      "strokeok",
      "shadowok",
      "arrowok",
      "gradientshapeok",
      "textpathok",
      "insetpenok",
      "connecttype",
      "connectlocs",
      "connectangles",
      "extrusionok"
    };
    private static byte[] attributeNamespaceIds = new byte[15]
    {
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
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "path";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12577;

    public override string LocalName
    {
      get
      {
        return "path";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12577;
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
        return Path.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Path.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
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

    [SchemaAttr(0, "v")]
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

    [SchemaAttr(0, "limo")]
    public StringValue Limo
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

    [SchemaAttr(0, "textboxrect")]
    public StringValue TextboxRectangle
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

    [SchemaAttr(0, "fillok")]
    public TrueFalseValue AllowFill
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

    [SchemaAttr(0, "strokeok")]
    public TrueFalseValue AllowStroke
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

    [SchemaAttr(0, "shadowok")]
    public TrueFalseValue AllowShading
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

    [SchemaAttr(0, "arrowok")]
    public TrueFalseValue ShowArrowhead
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

    [SchemaAttr(0, "gradientshapeok")]
    public TrueFalseValue AllowGradientShape
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

    [SchemaAttr(0, "textpathok")]
    public TrueFalseValue AllowTextPath
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

    [SchemaAttr(0, "insetpenok")]
    public TrueFalseValue AllowInsetPen
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

    [SchemaAttr(27, "connecttype")]
    public EnumValue<ConnectValues> ConnectionPointType
    {
      get
      {
        return (EnumValue<ConnectValues>) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "connectlocs")]
    public StringValue ConnectionPoints
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "connectangles")]
    public StringValue ConnectAngles
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "extrusionok")]
    public TrueFalseValue AllowExtrusion
    {
      get
      {
        return (TrueFalseValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "v" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "limo" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "textboxrect" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fillok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "strokeok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "shadowok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "arrowok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "gradientshapeok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "textpathok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "insetpenok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "connecttype" == name)
        return (OpenXmlSimpleType) new EnumValue<ConnectValues>();
      if (27 == (int) namespaceId && "connectlocs" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "connectangles" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "extrusionok" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Path>(deep);
    }
  }
}
