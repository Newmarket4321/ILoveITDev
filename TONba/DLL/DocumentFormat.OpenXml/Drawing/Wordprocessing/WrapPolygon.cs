﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [ChildElementInfo(typeof (LineTo))]
  [ChildElementInfo(typeof (StartPoint))]
  [GeneratedCode("DomGen", "2.0")]
  public class WrapPolygon : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "edited"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[2]
    {
      "start",
      "lineTo"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 16,
      (byte) 16
    };
    private const string tagName = "wrapPolygon";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10770;

    public override string LocalName
    {
      get
      {
        return "wrapPolygon";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 16;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10770;
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
        return WrapPolygon.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WrapPolygon.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "edited")]
    public BooleanValue Edited
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

    public WrapPolygon()
    {
    }

    public WrapPolygon(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WrapPolygon(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WrapPolygon(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "start" == name)
        return (OpenXmlElement) new StartPoint();
      if (16 == (int) namespaceId && "lineTo" == name)
        return (OpenXmlElement) new LineTo();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WrapPolygon.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WrapPolygon.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StartPoint StartPoint
    {
      get
      {
        return this.GetElement<StartPoint>(0);
      }
      set
      {
        this.SetElement<StartPoint>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "edited" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WrapPolygon>(deep);
    }
  }
}
