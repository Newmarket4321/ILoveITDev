// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Level
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LevelSuffix))]
  [ChildElementInfo(typeof (NumberingSymbolRunProperties))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (LevelRestart))]
  [ChildElementInfo(typeof (ParagraphStyleIdInLevel))]
  [ChildElementInfo(typeof (IsLegalNumberingStyle))]
  [ChildElementInfo(typeof (StartNumberingValue))]
  [ChildElementInfo(typeof (LevelText))]
  [ChildElementInfo(typeof (LevelPictureBulletId))]
  [ChildElementInfo(typeof (LegacyNumbering))]
  [ChildElementInfo(typeof (LevelJustification))]
  [ChildElementInfo(typeof (PreviousParagraphProperties))]
  public class Level : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "ilvl",
      "tplc",
      "tentative"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[12]
    {
      "start",
      "numFmt",
      "lvlRestart",
      "pStyle",
      "isLgl",
      "suff",
      "lvlText",
      "lvlPicBulletId",
      "legacy",
      "lvlJc",
      "pPr",
      "rPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[12]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "lvl";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11928;

    public override string LocalName
    {
      get
      {
        return "lvl";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11928;
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
        return Level.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Level.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "ilvl")]
    public Int32Value LevelIndex
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tplc")]
    public HexBinaryValue TemplateCode
    {
      get
      {
        return (HexBinaryValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tentative")]
    public OnOffValue Tentative
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Level()
    {
    }

    public Level(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Level(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Level(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlElement) new StartNumberingValue();
      if (23 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new NumberingFormat();
      if (23 == (int) namespaceId && "lvlRestart" == name)
        return (OpenXmlElement) new LevelRestart();
      if (23 == (int) namespaceId && "pStyle" == name)
        return (OpenXmlElement) new ParagraphStyleIdInLevel();
      if (23 == (int) namespaceId && "isLgl" == name)
        return (OpenXmlElement) new IsLegalNumberingStyle();
      if (23 == (int) namespaceId && "suff" == name)
        return (OpenXmlElement) new LevelSuffix();
      if (23 == (int) namespaceId && "lvlText" == name)
        return (OpenXmlElement) new LevelText();
      if (23 == (int) namespaceId && "lvlPicBulletId" == name)
        return (OpenXmlElement) new LevelPictureBulletId();
      if (23 == (int) namespaceId && "legacy" == name)
        return (OpenXmlElement) new LegacyNumbering();
      if (23 == (int) namespaceId && "lvlJc" == name)
        return (OpenXmlElement) new LevelJustification();
      if (23 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new PreviousParagraphProperties();
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new NumberingSymbolRunProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Level.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Level.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StartNumberingValue StartNumberingValue
    {
      get
      {
        return this.GetElement<StartNumberingValue>(0);
      }
      set
      {
        this.SetElement<StartNumberingValue>(0, value);
      }
    }

    public NumberingFormat NumberingFormat
    {
      get
      {
        return this.GetElement<NumberingFormat>(1);
      }
      set
      {
        this.SetElement<NumberingFormat>(1, value);
      }
    }

    public LevelRestart LevelRestart
    {
      get
      {
        return this.GetElement<LevelRestart>(2);
      }
      set
      {
        this.SetElement<LevelRestart>(2, value);
      }
    }

    public ParagraphStyleIdInLevel ParagraphStyleIdInLevel
    {
      get
      {
        return this.GetElement<ParagraphStyleIdInLevel>(3);
      }
      set
      {
        this.SetElement<ParagraphStyleIdInLevel>(3, value);
      }
    }

    public IsLegalNumberingStyle IsLegalNumberingStyle
    {
      get
      {
        return this.GetElement<IsLegalNumberingStyle>(4);
      }
      set
      {
        this.SetElement<IsLegalNumberingStyle>(4, value);
      }
    }

    public LevelSuffix LevelSuffix
    {
      get
      {
        return this.GetElement<LevelSuffix>(5);
      }
      set
      {
        this.SetElement<LevelSuffix>(5, value);
      }
    }

    public LevelText LevelText
    {
      get
      {
        return this.GetElement<LevelText>(6);
      }
      set
      {
        this.SetElement<LevelText>(6, value);
      }
    }

    public LevelPictureBulletId LevelPictureBulletId
    {
      get
      {
        return this.GetElement<LevelPictureBulletId>(7);
      }
      set
      {
        this.SetElement<LevelPictureBulletId>(7, value);
      }
    }

    public LegacyNumbering LegacyNumbering
    {
      get
      {
        return this.GetElement<LegacyNumbering>(8);
      }
      set
      {
        this.SetElement<LegacyNumbering>(8, value);
      }
    }

    public LevelJustification LevelJustification
    {
      get
      {
        return this.GetElement<LevelJustification>(9);
      }
      set
      {
        this.SetElement<LevelJustification>(9, value);
      }
    }

    public PreviousParagraphProperties PreviousParagraphProperties
    {
      get
      {
        return this.GetElement<PreviousParagraphProperties>(10);
      }
      set
      {
        this.SetElement<PreviousParagraphProperties>(10, value);
      }
    }

    public NumberingSymbolRunProperties NumberingSymbolRunProperties
    {
      get
      {
        return this.GetElement<NumberingSymbolRunProperties>(11);
      }
      set
      {
        this.SetElement<NumberingSymbolRunProperties>(11, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "ilvl" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "tplc" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "tentative" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Level>(deep);
    }
  }
}
