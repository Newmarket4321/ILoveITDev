// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Field
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunProperties))]
  [ChildElementInfo(typeof (ParagraphProperties))]
  [ChildElementInfo(typeof (Text))]
  public class Field : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "type"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "rPr",
      "pPr",
      "t"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "fld";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10119;

    public override string LocalName
    {
      get
      {
        return "fld";
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
        return 10119;
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
        return Field.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Field.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
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

    [SchemaAttr(0, "type")]
    public StringValue Type
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

    public Field()
    {
    }

    public Field(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Field(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Field(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (10 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new ParagraphProperties();
      if (10 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new Text();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Field.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Field.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunProperties RunProperties
    {
      get
      {
        return this.GetElement<RunProperties>(0);
      }
      set
      {
        this.SetElement<RunProperties>(0, value);
      }
    }

    public ParagraphProperties ParagraphProperties
    {
      get
      {
        return this.GetElement<ParagraphProperties>(1);
      }
      set
      {
        this.SetElement<ParagraphProperties>(1, value);
      }
    }

    public Text Text
    {
      get
      {
        return this.GetElement<Text>(2);
      }
      set
      {
        this.SetElement<Text>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Field>(deep);
    }
  }
}
