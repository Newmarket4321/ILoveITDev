// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.FileVersion
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class FileVersion : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "appName",
      "lastEdited",
      "lowestEdited",
      "rupBuild",
      "codeName"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "fileVersion";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11519;

    public override string LocalName
    {
      get
      {
        return "fileVersion";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11519;
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
        return FileVersion.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FileVersion.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "appName")]
    public StringValue ApplicationName
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

    [SchemaAttr(0, "lastEdited")]
    public StringValue LastEdited
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

    [SchemaAttr(0, "lowestEdited")]
    public StringValue LowestEdited
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

    [SchemaAttr(0, "rupBuild")]
    public StringValue BuildVersion
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

    [SchemaAttr(0, "codeName")]
    public StringValue CodeName
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "appName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lastEdited" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lowestEdited" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rupBuild" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "codeName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FileVersion>(deep);
    }
  }
}
