// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [ChildElementInfo(typeof (PresetDash))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (TailEnd))]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Round))]
  [ChildElementInfo(typeof (LineJoinBevel))]
  [ChildElementInfo(typeof (Miter))]
  [ChildElementInfo(typeof (HeadEnd))]
  [ChildElementInfo(typeof (CustomDash))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class HiddenLineProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "w",
      "cap",
      "cmpd",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "hiddenLine";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12787;

    public override string LocalName
    {
      get
      {
        return "hiddenLine";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12787;
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
        return HiddenLineProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HiddenLineProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "w")]
    public Int32Value Width
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

    [SchemaAttr(0, "cap")]
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

    [SchemaAttr(0, "cmpd")]
    public EnumValue<CompoundLineValues> CompoundLineType
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

    [SchemaAttr(0, "algn")]
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

    public HiddenLineProperties()
    {
    }

    public HiddenLineProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HiddenLineProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HiddenLineProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "prstDash" == name)
        return (OpenXmlElement) new PresetDash();
      if (10 == (int) namespaceId && "custDash" == name)
        return (OpenXmlElement) new CustomDash();
      if (10 == (int) namespaceId && "round" == name)
        return (OpenXmlElement) new Round();
      if (10 == (int) namespaceId && "bevel" == name)
        return (OpenXmlElement) new LineJoinBevel();
      if (10 == (int) namespaceId && "miter" == name)
        return (OpenXmlElement) new Miter();
      if (10 == (int) namespaceId && "headEnd" == name)
        return (OpenXmlElement) new HeadEnd();
      if (10 == (int) namespaceId && "tailEnd" == name)
        return (OpenXmlElement) new TailEnd();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "w" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "cap" == name)
        return (OpenXmlSimpleType) new EnumValue<LineCapValues>();
      if ((int) namespaceId == 0 && "cmpd" == name)
        return (OpenXmlSimpleType) new EnumValue<CompoundLineValues>();
      if ((int) namespaceId == 0 && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<PenAlignmentValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HiddenLineProperties>(deep);
    }
  }
}
