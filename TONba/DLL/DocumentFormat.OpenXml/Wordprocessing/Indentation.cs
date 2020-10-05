// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Indentation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Indentation : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "left",
      "start",
      "leftChars",
      "startChars",
      "right",
      "end",
      "rightChars",
      "endChars",
      "hanging",
      "hangingChars",
      "firstLine",
      "firstLineChars"
    };
    private static byte[] attributeNamespaceIds = new byte[12]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "ind";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11578;

    public override string LocalName
    {
      get
      {
        return "ind";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11578;
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
        return Indentation.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Indentation.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "left")]
    public StringValue Left
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

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "start")]
    public StringValue Start
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

    [SchemaAttr(23, "leftChars")]
    public Int32Value LeftChars
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "startChars")]
    public Int32Value StartCharacters
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "right")]
    public StringValue Right
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "end")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public StringValue End
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "rightChars")]
    public Int32Value RightChars
    {
      get
      {
        return (Int32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "endChars")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public Int32Value EndCharacters
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hanging")]
    public StringValue Hanging
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hangingChars")]
    public Int32Value HangingChars
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "firstLine")]
    public StringValue FirstLine
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "firstLineChars")]
    public Int32Value FirstLineChars
    {
      get
      {
        return (Int32Value) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "left" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "leftChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "startChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "right" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "end" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "rightChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "endChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "hanging" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "hangingChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "firstLine" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "firstLineChars" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Indentation>(deep);
    }
  }
}
