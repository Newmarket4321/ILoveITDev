// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LevelOverride
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StartOverrideNumberingValue))]
  [ChildElementInfo(typeof (Level))]
  public class LevelOverride : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ilvl"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "startOverride",
      "lvl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "lvlOverride";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11931;

    public override string LocalName
    {
      get
      {
        return "lvlOverride";
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
        return 11931;
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
        return LevelOverride.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LevelOverride.attributeNamespaceIds;
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

    public LevelOverride()
    {
    }

    public LevelOverride(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LevelOverride(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LevelOverride(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "startOverride" == name)
        return (OpenXmlElement) new StartOverrideNumberingValue();
      if (23 == (int) namespaceId && "lvl" == name)
        return (OpenXmlElement) new Level();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LevelOverride.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LevelOverride.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StartOverrideNumberingValue StartOverrideNumberingValue
    {
      get
      {
        return this.GetElement<StartOverrideNumberingValue>(0);
      }
      set
      {
        this.SetElement<StartOverrideNumberingValue>(0, value);
      }
    }

    public Level Level
    {
      get
      {
        return this.GetElement<Level>(1);
      }
      set
      {
        this.SetElement<Level>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "ilvl" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LevelOverride>(deep);
    }
  }
}
