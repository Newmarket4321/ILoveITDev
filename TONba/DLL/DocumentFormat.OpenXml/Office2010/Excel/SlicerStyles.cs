// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SlicerStyle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class SlicerStyles : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "defaultSlicerStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "slicerStyles";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12980;

    public override string LocalName
    {
      get
      {
        return "slicerStyles";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12980;
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
        return SlicerStyles.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlicerStyles.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "defaultSlicerStyle")]
    public StringValue DefaultSlicerStyle
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

    public SlicerStyles()
    {
    }

    public SlicerStyles(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerStyles(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerStyles(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "slicerStyle" == name)
        return (OpenXmlElement) new SlicerStyle();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "defaultSlicerStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerStyles>(deep);
    }
  }
}
