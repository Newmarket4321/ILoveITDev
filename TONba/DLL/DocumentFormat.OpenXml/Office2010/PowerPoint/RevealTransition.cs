// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.RevealTransition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class RevealTransition : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "thruBlk",
      "dir"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "reveal";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12852;

    public override string LocalName
    {
      get
      {
        return "reveal";
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
        return 12852;
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
        return RevealTransition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RevealTransition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "thruBlk")]
    public BooleanValue ThroughBlack
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

    [SchemaAttr(0, "dir")]
    public EnumValue<TransitionLeftRightDirectionTypeValues> Direction
    {
      get
      {
        return (EnumValue<TransitionLeftRightDirectionTypeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "thruBlk" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new EnumValue<TransitionLeftRightDirectionTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RevealTransition>(deep);
    }
  }
}
