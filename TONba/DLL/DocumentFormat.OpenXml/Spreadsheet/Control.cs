// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Control
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ControlProperties), FileFormatVersions.Office2010)]
  public class Control : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "shapeId",
      "id",
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 0,
      (byte) 19,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "controlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "control";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11277;

    public override string LocalName
    {
      get
      {
        return "control";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11277;
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
        return Control.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Control.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "shapeId")]
    public UInt32Value ShapeId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Control()
    {
    }

    public Control(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Control(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Control(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "controlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Control.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Control.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(0);
      }
      set
      {
        this.SetElement<ControlProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "shapeId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Control>(deep);
    }
  }
}
