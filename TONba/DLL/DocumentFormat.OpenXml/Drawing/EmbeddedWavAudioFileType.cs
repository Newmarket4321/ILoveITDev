// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class EmbeddedWavAudioFileType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "embed",
      "name",
      "builtIn"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 19,
      (byte) 0,
      (byte) 0
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return EmbeddedWavAudioFileType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EmbeddedWavAudioFileType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "embed")]
    public StringValue Embed
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

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "builtIn")]
    public BooleanValue BuiltIn
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "embed" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "builtIn" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
