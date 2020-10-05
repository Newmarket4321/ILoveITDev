// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.AlphaModulationFixed
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class AlphaModulationFixed : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "amt"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "alphaModFix";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10060;

    public override string LocalName
    {
      get
      {
        return "alphaModFix";
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
        return 10060;
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
        return AlphaModulationFixed.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AlphaModulationFixed.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "amt")]
    public Int32Value Amount
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "amt" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AlphaModulationFixed>(deep);
    }
  }
}
