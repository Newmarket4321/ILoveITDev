// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.BuildDiagram
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class BuildDiagram : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "bld",
      "rev"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "bldDgm";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10174;

    public override string LocalName
    {
      get
      {
        return "bldDgm";
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
        return 10174;
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
        return BuildDiagram.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BuildDiagram.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "bld")]
    public StringValue Build
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

    [SchemaAttr(0, "rev")]
    public BooleanValue ReverseAnimation
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "bld" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rev" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BuildDiagram>(deep);
    }
  }
}
