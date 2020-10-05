// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (CameraTool), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ObjectProperties), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SignatureLine), FileFormatVersions.Office2013)]
  public class NonVisualPicturePropertiesExtension : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ext";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10332;

    public override string LocalName
    {
      get
      {
        return "ext";
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
        return 10332;
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
        return NonVisualPicturePropertiesExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NonVisualPicturePropertiesExtension.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
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

    public NonVisualPicturePropertiesExtension()
    {
    }

    public NonVisualPicturePropertiesExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualPicturePropertiesExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualPicturePropertiesExtension(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "cameraTool" == name)
        return (OpenXmlElement) new CameraTool();
      if (67 == (int) namespaceId && "signatureLine" == name)
        return (OpenXmlElement) new SignatureLine();
      if (67 == (int) namespaceId && "objectPr" == name)
        return (OpenXmlElement) new ObjectProperties();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualPicturePropertiesExtension>(deep);
    }
  }
}
