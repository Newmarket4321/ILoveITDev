// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ExternalBook
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExternalDefinedNames))]
  [ChildElementInfo(typeof (SheetDataSet))]
  [ChildElementInfo(typeof (SheetNames))]
  public class ExternalBook : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[3]
    {
      "sheetNames",
      "definedNames",
      "sheetDataSet"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "externalBook";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11342;

    public override string LocalName
    {
      get
      {
        return "externalBook";
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
        return 11342;
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
        return ExternalBook.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ExternalBook.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public ExternalBook()
    {
    }

    public ExternalBook(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExternalBook(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExternalBook(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "sheetNames" == name)
        return (OpenXmlElement) new SheetNames();
      if (22 == (int) namespaceId && "definedNames" == name)
        return (OpenXmlElement) new ExternalDefinedNames();
      if (22 == (int) namespaceId && "sheetDataSet" == name)
        return (OpenXmlElement) new SheetDataSet();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ExternalBook.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ExternalBook.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SheetNames SheetNames
    {
      get
      {
        return this.GetElement<SheetNames>(0);
      }
      set
      {
        this.SetElement<SheetNames>(0, value);
      }
    }

    public ExternalDefinedNames ExternalDefinedNames
    {
      get
      {
        return this.GetElement<ExternalDefinedNames>(1);
      }
      set
      {
        this.SetElement<ExternalDefinedNames>(1, value);
      }
    }

    public SheetDataSet SheetDataSet
    {
      get
      {
        return this.GetElement<SheetDataSet>(2);
      }
      set
      {
        this.SetElement<SheetDataSet>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExternalBook>(deep);
    }
  }
}
