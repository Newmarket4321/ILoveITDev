// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.PatternFill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ForegroundColor))]
  [ChildElementInfo(typeof (BackgroundColor))]
  public class PatternFill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "prst"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "fgClr",
      "bgClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "pattFill";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10051;

    public override string LocalName
    {
      get
      {
        return "pattFill";
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
        return 10051;
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
        return PatternFill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PatternFill.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prst")]
    public EnumValue<PresetPatternValues> Preset
    {
      get
      {
        return (EnumValue<PresetPatternValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public PatternFill()
    {
    }

    public PatternFill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PatternFill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PatternFill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "fgClr" == name)
        return (OpenXmlElement) new ForegroundColor();
      if (10 == (int) namespaceId && "bgClr" == name)
        return (OpenXmlElement) new BackgroundColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PatternFill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PatternFill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ForegroundColor ForegroundColor
    {
      get
      {
        return this.GetElement<ForegroundColor>(0);
      }
      set
      {
        this.SetElement<ForegroundColor>(0, value);
      }
    }

    public BackgroundColor BackgroundColor
    {
      get
      {
        return this.GetElement<BackgroundColor>(1);
      }
      set
      {
        this.SetElement<BackgroundColor>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prst" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetPatternValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PatternFill>(deep);
    }
  }
}
