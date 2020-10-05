// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ConnectionSite
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Position))]
  public class ConnectionSite : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ang"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "pos"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "cxn";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10217;

    public override string LocalName
    {
      get
      {
        return "cxn";
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
        return 10217;
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
        return ConnectionSite.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ConnectionSite.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ang")]
    public StringValue Angle
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

    public ConnectionSite()
    {
    }

    public ConnectionSite(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ConnectionSite(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ConnectionSite(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new Position();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ConnectionSite.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ConnectionSite.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(0);
      }
      set
      {
        this.SetElement<Position>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ang" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConnectionSite>(deep);
    }
  }
}
