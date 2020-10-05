// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.SampleRate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  public class SampleRate : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "uniform",
      "value"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "sampleRate";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12723;

    public override string LocalName
    {
      get
      {
        return "sampleRate";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12723;
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
        return SampleRate.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SampleRate.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uniform")]
    public BooleanValue Uniform
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "value")]
    public DecimalValue Value
    {
      get
      {
        return (DecimalValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniform" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "value" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SampleRate>(deep);
    }
  }
}
