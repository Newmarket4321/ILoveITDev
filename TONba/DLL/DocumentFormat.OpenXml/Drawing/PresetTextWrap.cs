// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.PresetTextWrap
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (AdjustValueList))]
  [GeneratedCode("DomGen", "2.0")]
  public class PresetTextWrap : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "prst"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "avLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "prstTxWarp";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10087;

    public override string LocalName
    {
      get
      {
        return "prstTxWarp";
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
        return 10087;
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
        return PresetTextWrap.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PresetTextWrap.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prst")]
    public EnumValue<TextShapeValues> Preset
    {
      get
      {
        return (EnumValue<TextShapeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public PresetTextWrap()
    {
    }

    public PresetTextWrap(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PresetTextWrap(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PresetTextWrap(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "avLst" == name)
        return (OpenXmlElement) new AdjustValueList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PresetTextWrap.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PresetTextWrap.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AdjustValueList AdjustValueList
    {
      get
      {
        return this.GetElement<AdjustValueList>(0);
      }
      set
      {
        this.SetElement<AdjustValueList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prst" == name)
        return (OpenXmlSimpleType) new EnumValue<TextShapeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresetTextWrap>(deep);
    }
  }
}
