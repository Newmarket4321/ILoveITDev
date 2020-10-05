// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class NonVisualGroupProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "isLegacyGroup"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "nonVisualGroupProps";
    private const byte tagNsId = 67;
    internal const int ElementTypeIdConst = 13322;

    public override string LocalName
    {
      get
      {
        return "nonVisualGroupProps";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 67;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13322;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return NonVisualGroupProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NonVisualGroupProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "isLegacyGroup")]
    public BooleanValue IsLegacyGroup
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "isLegacyGroup" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualGroupProperties>(deep);
    }
  }
}
