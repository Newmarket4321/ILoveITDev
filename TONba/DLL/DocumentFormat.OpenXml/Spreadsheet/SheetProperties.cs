// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SheetProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TabColor))]
  [ChildElementInfo(typeof (OutlineProperties))]
  [ChildElementInfo(typeof (PageSetupProperties))]
  public class SheetProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "syncHorizontal",
      "syncVertical",
      "syncRef",
      "transitionEvaluation",
      "transitionEntry",
      "published",
      "codeName",
      "filterMode",
      "enableFormatConditionsCalculation"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private static readonly string[] eleTagNames = new string[3]
    {
      "tabColor",
      "outlinePr",
      "pageSetUpPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "sheetPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11404;

    public override string LocalName
    {
      get
      {
        return "sheetPr";
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
        return 11404;
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
        return SheetProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SheetProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "syncHorizontal")]
    public BooleanValue SyncHorizontal
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

    [SchemaAttr(0, "syncVertical")]
    public BooleanValue SyncVertical
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

    [SchemaAttr(0, "syncRef")]
    public StringValue SyncReference
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "transitionEvaluation")]
    public BooleanValue TransitionEvaluation
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

    [SchemaAttr(0, "transitionEntry")]
    public BooleanValue TransitionEntry
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "published")]
    public BooleanValue Published
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "codeName")]
    public StringValue CodeName
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterMode")]
    public BooleanValue FilterMode
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "enableFormatConditionsCalculation")]
    public BooleanValue EnableFormatConditionsCalculation
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public SheetProperties()
    {
    }

    public SheetProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SheetProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SheetProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "tabColor" == name)
        return (OpenXmlElement) new TabColor();
      if (22 == (int) namespaceId && "outlinePr" == name)
        return (OpenXmlElement) new OutlineProperties();
      if (22 == (int) namespaceId && "pageSetUpPr" == name)
        return (OpenXmlElement) new PageSetupProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SheetProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SheetProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TabColor TabColor
    {
      get
      {
        return this.GetElement<TabColor>(0);
      }
      set
      {
        this.SetElement<TabColor>(0, value);
      }
    }

    public OutlineProperties OutlineProperties
    {
      get
      {
        return this.GetElement<OutlineProperties>(1);
      }
      set
      {
        this.SetElement<OutlineProperties>(1, value);
      }
    }

    public PageSetupProperties PageSetupProperties
    {
      get
      {
        return this.GetElement<PageSetupProperties>(2);
      }
      set
      {
        this.SetElement<PageSetupProperties>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "syncHorizontal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "syncVertical" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "syncRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "transitionEvaluation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "transitionEntry" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "published" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "codeName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "filterMode" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "enableFormatConditionsCalculation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SheetProperties>(deep);
    }
  }
}
