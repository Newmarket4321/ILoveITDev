// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RevisionDefinedName
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (OldFormula))]
  [ChildElementInfo(typeof (Formula))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class RevisionDefinedName : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[24]
    {
      "rId",
      "ua",
      "ra",
      "localSheetId",
      "customView",
      "name",
      "function",
      "oldFunction",
      "functionGroupId",
      "oldFunctionGroupId",
      "shortcutKey",
      "oldShortcutKey",
      "hidden",
      "oldHidden",
      "customMenu",
      "oldCustomMenu",
      "description",
      "oldDescription",
      "help",
      "oldHelp",
      "statusBar",
      "oldStatusBar",
      "comment",
      "oldComment"
    };
    private static byte[] attributeNamespaceIds = new byte[24];
    private static readonly string[] eleTagNames = new string[3]
    {
      "formula",
      "oldFormula",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "rdn";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11227;

    public override string LocalName
    {
      get
      {
        return "rdn";
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
        return 11227;
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
        return RevisionDefinedName.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RevisionDefinedName.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rId")]
    public UInt32Value RevisionId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ua")]
    public BooleanValue Ua
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

    [SchemaAttr(0, "ra")]
    public BooleanValue Ra
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

    [SchemaAttr(0, "localSheetId")]
    public UInt32Value LocalSheetId
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customView")]
    public BooleanValue CustomView
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

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "function")]
    public BooleanValue Function
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldFunction")]
    public BooleanValue OldFunction
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

    [SchemaAttr(0, "functionGroupId")]
    public ByteValue FunctionGroupId
    {
      get
      {
        return (ByteValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldFunctionGroupId")]
    public ByteValue OldFunctionGroupId
    {
      get
      {
        return (ByteValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shortcutKey")]
    public ByteValue ShortcutKey
    {
      get
      {
        return (ByteValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldShortcutKey")]
    public ByteValue OldShortcutKey
    {
      get
      {
        return (ByteValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldHidden")]
    public BooleanValue OldHidden
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customMenu")]
    public StringValue CustomMenu
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldCustomMenu")]
    public StringValue OldCustomMenu
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "description")]
    public StringValue Description
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldDescription")]
    public StringValue OldDescription
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "help")]
    public StringValue Help
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldHelp")]
    public StringValue OldHelp
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "statusBar")]
    public StringValue StatusBar
    {
      get
      {
        return (StringValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldStatusBar")]
    public StringValue OldStatusBar
    {
      get
      {
        return (StringValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "comment")]
    public StringValue Comment
    {
      get
      {
        return (StringValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldComment")]
    public StringValue OldComment
    {
      get
      {
        return (StringValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    public RevisionDefinedName()
    {
    }

    public RevisionDefinedName(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RevisionDefinedName(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RevisionDefinedName(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "formula" == name)
        return (OpenXmlElement) new Formula();
      if (22 == (int) namespaceId && "oldFormula" == name)
        return (OpenXmlElement) new OldFormula();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RevisionDefinedName.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RevisionDefinedName.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(0);
      }
      set
      {
        this.SetElement<Formula>(0, value);
      }
    }

    public OldFormula OldFormula
    {
      get
      {
        return this.GetElement<OldFormula>(1);
      }
      set
      {
        this.SetElement<OldFormula>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "ua" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ra" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "localSheetId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "customView" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "function" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "oldFunction" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "functionGroupId" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "oldFunctionGroupId" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "shortcutKey" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "oldShortcutKey" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "oldHidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "customMenu" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oldCustomMenu" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oldDescription" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "help" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oldHelp" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "statusBar" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oldStatusBar" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "comment" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oldComment" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RevisionDefinedName>(deep);
    }
  }
}
