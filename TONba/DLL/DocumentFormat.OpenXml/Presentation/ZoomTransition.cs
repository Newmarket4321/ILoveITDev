// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ZoomTransition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public class ZoomTransition : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "dir"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "zoom";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12466;

    public override string LocalName
    {
      get
      {
        return "zoom";
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
        return 12466;
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
        return ZoomTransition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ZoomTransition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "dir")]
    public EnumValue<TransitionInOutDirectionValues> Direction
    {
      get
      {
        return (EnumValue<TransitionInOutDirectionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new EnumValue<TransitionInOutDirectionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ZoomTransition>(deep);
    }
  }
}
