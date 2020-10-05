// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.RoamingProperty
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
{
  [ChildElementInfo(typeof (Key), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Value), FileFormatVersions.Office2013)]
  public class RoamingProperty : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "key",
      "value"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 76,
      (byte) 76
    };
    private const string tagName = "props";
    private const byte tagNsId = 76;
    internal const int ElementTypeIdConst = 13440;

    public override string LocalName
    {
      get
      {
        return "props";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 76;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13440;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public RoamingProperty()
    {
    }

    public RoamingProperty(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RoamingProperty(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RoamingProperty(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (76 == (int) namespaceId && "key" == name)
        return (OpenXmlElement) new Key();
      if (76 == (int) namespaceId && "value" == name)
        return (OpenXmlElement) new Value();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RoamingProperty.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RoamingProperty.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Key Key
    {
      get
      {
        return this.GetElement<Key>(0);
      }
      set
      {
        this.SetElement<Key>(0, value);
      }
    }

    public Value Value
    {
      get
      {
        return this.GetElement<Value>(1);
      }
      set
      {
        this.SetElement<Value>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RoamingProperty>(deep);
    }
  }
}
