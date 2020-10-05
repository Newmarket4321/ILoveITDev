// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DdeItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Values))]
  public class DdeItem : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "name",
      "ole",
      "advise",
      "preferPic"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[1]
    {
      "values"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "ddeItem";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11338;

    public override string LocalName
    {
      get
      {
        return "ddeItem";
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
        return 11338;
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
        return DdeItem.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DdeItem.attributeNamespaceIds;
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

    [SchemaAttr(0, "ole")]
    public BooleanValue UseOle
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

    [SchemaAttr(0, "advise")]
    public BooleanValue Advise
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

    [SchemaAttr(0, "preferPic")]
    public BooleanValue PreferPicture
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public DdeItem()
    {
    }

    public DdeItem(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DdeItem(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DdeItem(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "values" == name)
        return (OpenXmlElement) new Values();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DdeItem.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DdeItem.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Values Values
    {
      get
      {
        return this.GetElement<Values>(0);
      }
      set
      {
        this.SetElement<Values>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "ole" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "advise" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "preferPic" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DdeItem>(deep);
    }
  }
}
