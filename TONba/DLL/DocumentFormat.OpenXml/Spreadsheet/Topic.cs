﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Topic
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Xstring))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Subtopic))]
  [ChildElementInfo(typeof (TopicReferences))]
  public class Topic : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "t"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "v",
      "stp",
      "tr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "tp";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11354;

    public override string LocalName
    {
      get
      {
        return "tp";
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
        return 11354;
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
        return Topic.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Topic.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "t")]
    public EnumValue<VolatileValues> ValueType
    {
      get
      {
        return (EnumValue<VolatileValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Topic()
    {
    }

    public Topic(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Topic(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Topic(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "v" == name)
        return (OpenXmlElement) new Xstring();
      if (22 == (int) namespaceId && "stp" == name)
        return (OpenXmlElement) new Subtopic();
      if (22 == (int) namespaceId && "tr" == name)
        return (OpenXmlElement) new TopicReferences();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Topic.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Topic.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Xstring Xstring
    {
      get
      {
        return this.GetElement<Xstring>(0);
      }
      set
      {
        this.SetElement<Xstring>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new EnumValue<VolatileValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Topic>(deep);
    }
  }
}
