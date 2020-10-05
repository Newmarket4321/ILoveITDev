// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.TracePoint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class TracePoint : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "t",
      "x",
      "y"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "tracePt";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12878;

    public override string LocalName
    {
      get
      {
        return "tracePt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12878;
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
        return TracePoint.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TracePoint.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "t")]
    public StringValue Time
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

    [SchemaAttr(0, "x")]
    public Int64Value XCoordinate
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "y")]
    public Int64Value YCoordinate
    {
      get
      {
        return (Int64Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "x" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "y" == name)
        return (OpenXmlSimpleType) new Int64Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TracePoint>(deep);
    }
  }
}
