// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.Person
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PresenceInfo), FileFormatVersions.Office2013)]
  public class Person : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "author",
      "contact"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 69,
      (byte) 69
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "presenceInfo"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 69
    };
    private const string tagName = "person";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13349;

    public override string LocalName
    {
      get
      {
        return "person";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13349;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Person.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Person.attributeNamespaceIds;
      }
    }

    [SchemaAttr(69, "author")]
    public StringValue Author
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

    [SchemaAttr(69, "contact")]
    public StringValue Contact
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

    public Person()
    {
    }

    public Person(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Person(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Person(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "presenceInfo" == name)
        return (OpenXmlElement) new PresenceInfo();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Person.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Person.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PresenceInfo PresenceInfo
    {
      get
      {
        return this.GetElement<PresenceInfo>(0);
      }
      set
      {
        this.SetElement<PresenceInfo>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (69 == (int) namespaceId && "contact" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Person>(deep);
    }
  }
}
