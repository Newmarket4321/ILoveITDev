// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomProperties.Properties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.CustomProperties
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomDocumentProperty))]
  public class Properties : OpenXmlPartRootElement
  {
    private const string tagName = "Properties";
    private const byte tagNsId = 4;
    internal const int ElementTypeIdConst = 10903;

    public override string LocalName
    {
      get
      {
        return nameof (Properties);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 4;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10903;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Properties(CustomFilePropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomFilePropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CustomFilePropertiesPart CustomFilePropertiesPart
    {
      get
      {
        return this.OpenXmlPart as CustomFilePropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Properties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Properties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Properties(string outerXml)
      : base(outerXml)
    {
    }

    public Properties()
    {
    }

    public void Save(CustomFilePropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (4 == (int) namespaceId && "property" == name)
        return (OpenXmlElement) new CustomDocumentProperty();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Properties>(deep);
    }
  }
}
