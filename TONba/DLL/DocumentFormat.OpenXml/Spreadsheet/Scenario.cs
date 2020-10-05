﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Scenario
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (InputCells))]
  public class Scenario : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "name",
      "locked",
      "hidden",
      "count",
      "user",
      "comment"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "scenario";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11267;

    public override string LocalName
    {
      get
      {
        return "scenario";
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
        return 11267;
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
        return Scenario.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Scenario.attributeNamespaceIds;
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

    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "user")]
    public StringValue User
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "comment")]
    public StringValue Comment
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public Scenario()
    {
    }

    public Scenario(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Scenario(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Scenario(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "inputCells" == name)
        return (OpenXmlElement) new InputCells();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "locked" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "user" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "comment" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Scenario>(deep);
    }
  }
}
