// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (NoFillEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PresetLineDashProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RoundEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BevelEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LineJoinMiterProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SolidColorFillProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GradientFillProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class TextOutlineEffect : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "w",
      "cap",
      "cmpd",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "textOutline";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12923;

    public override string LocalName
    {
      get
      {
        return "textOutline";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12923;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return TextOutlineEffect.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextOutlineEffect.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "w")]
    public Int32Value LineWidth
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "cap")]
    public EnumValue<LineCapValues> CapType
    {
      get
      {
        return (EnumValue<LineCapValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "cmpd")]
    public EnumValue<CompoundLineValues> Compound
    {
      get
      {
        return (EnumValue<CompoundLineValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "algn")]
    public EnumValue<PenAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<PenAlignmentValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public TextOutlineEffect()
    {
    }

    public TextOutlineEffect(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextOutlineEffect(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextOutlineEffect(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFillEmpty();
      if (52 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidColorFillProperties();
      if (52 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFillProperties();
      if (52 == (int) namespaceId && "prstDash" == name)
        return (OpenXmlElement) new PresetLineDashProperties();
      if (52 == (int) namespaceId && "round" == name)
        return (OpenXmlElement) new RoundEmpty();
      if (52 == (int) namespaceId && "bevel" == name)
        return (OpenXmlElement) new BevelEmpty();
      if (52 == (int) namespaceId && "miter" == name)
        return (OpenXmlElement) new LineJoinMiterProperties();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "w" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "cap" == name)
        return (OpenXmlSimpleType) new EnumValue<LineCapValues>();
      if (52 == (int) namespaceId && "cmpd" == name)
        return (OpenXmlSimpleType) new EnumValue<CompoundLineValues>();
      if (52 == (int) namespaceId && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<PenAlignmentValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextOutlineEffect>(deep);
    }
  }
}
