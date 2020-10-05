// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Camera
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class Camera : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "prst"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private const string tagName = "camera";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12947;

    public override string LocalName
    {
      get
      {
        return "camera";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12947;
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
        return Camera.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Camera.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "prst")]
    public EnumValue<PresetCameraTypeValues> PresetCameraType
    {
      get
      {
        return (EnumValue<PresetCameraTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "prst" == name)
        return (OpenXmlSimpleType) new EnumValue<PresetCameraTypeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Camera>(deep);
    }
  }
}
