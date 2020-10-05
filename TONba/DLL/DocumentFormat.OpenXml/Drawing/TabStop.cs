// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TabStop
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class TabStop : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "pos",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "tab";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10302;

    public override string LocalName
    {
      get
      {
        return "tab";
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
        return 10302;
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
        return TabStop.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TabStop.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "pos")]
    public Int32Value Position
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

    [SchemaAttr(0, "algn")]
    public EnumValue<TextTabAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<TextTabAlignmentValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "pos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<TextTabAlignmentValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TabStop>(deep);
    }
  }
}
