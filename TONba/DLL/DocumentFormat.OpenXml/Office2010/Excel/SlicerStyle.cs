// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SlicerStyleElements), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class SlicerStyle : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "slicerStyleElements"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 53
    };
    private const string tagName = "slicerStyle";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13052;

    public override string LocalName
    {
      get
      {
        return "slicerStyle";
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
        return 13052;
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
        return SlicerStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlicerStyle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    public SlicerStyle()
    {
    }

    public SlicerStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerStyle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "slicerStyleElements" == name)
        return (OpenXmlElement) new SlicerStyleElements();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlicerStyle.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlicerStyle.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SlicerStyleElements SlicerStyleElements
    {
      get
      {
        return this.GetElement<SlicerStyleElements>(0);
      }
      set
      {
        this.SetElement<SlicerStyleElements>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerStyle>(deep);
    }
  }
}
