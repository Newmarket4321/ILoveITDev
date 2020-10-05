// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SplitTransition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public class SplitTransition : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "orient",
      "dir"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "split";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12461;

    public override string LocalName
    {
      get
      {
        return "split";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12461;
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
        return SplitTransition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SplitTransition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "orient")]
    public EnumValue<DirectionValues> Orientation
    {
      get
      {
        return (EnumValue<DirectionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dir")]
    public EnumValue<TransitionInOutDirectionValues> Direction
    {
      get
      {
        return (EnumValue<TransitionInOutDirectionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "orient" == name)
        return (OpenXmlSimpleType) new EnumValue<DirectionValues>();
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new EnumValue<TransitionInOutDirectionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SplitTransition>(deep);
    }
  }
}
