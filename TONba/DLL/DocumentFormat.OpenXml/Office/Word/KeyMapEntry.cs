// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.KeyMapEntry
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WllMacroKeyboardCustomization))]
  [ChildElementInfo(typeof (FixedCommandKeyboardCustomization))]
  [ChildElementInfo(typeof (MacroKeyboardCustomization))]
  [ChildElementInfo(typeof (AllocatedCommandKeyboardCustomization))]
  [ChildElementInfo(typeof (CharacterInsertion))]
  public class KeyMapEntry : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "chmPrimary",
      "chmSecondary",
      "kcmPrimary",
      "kcmSecondary",
      "mask"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private static readonly string[] eleTagNames = new string[5]
    {
      "fci",
      "macro",
      "acd",
      "wll",
      "wch"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "keymap";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12617;

    public override string LocalName
    {
      get
      {
        return "keymap";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12617;
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
        return KeyMapEntry.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return KeyMapEntry.attributeNamespaceIds;
      }
    }

    [SchemaAttr(33, "chmPrimary")]
    public HexBinaryValue CharacterMapPrimary
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "chmSecondary")]
    public HexBinaryValue CharacterMapSecondary
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

    [SchemaAttr(33, "kcmPrimary")]
    public HexBinaryValue KeyCodePrimary
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "kcmSecondary")]
    public HexBinaryValue KeyCodeSecondary
    {
      get
      {
        return (HexBinaryValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "mask")]
    public OnOffValue Mask
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public KeyMapEntry()
    {
    }

    public KeyMapEntry(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public KeyMapEntry(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public KeyMapEntry(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "fci" == name)
        return (OpenXmlElement) new FixedCommandKeyboardCustomization();
      if (33 == (int) namespaceId && "macro" == name)
        return (OpenXmlElement) new MacroKeyboardCustomization();
      if (33 == (int) namespaceId && "acd" == name)
        return (OpenXmlElement) new AllocatedCommandKeyboardCustomization();
      if (33 == (int) namespaceId && "wll" == name)
        return (OpenXmlElement) new WllMacroKeyboardCustomization();
      if (33 == (int) namespaceId && "wch" == name)
        return (OpenXmlElement) new CharacterInsertion();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return KeyMapEntry.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return KeyMapEntry.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public FixedCommandKeyboardCustomization FixedCommandKeyboardCustomization
    {
      get
      {
        return this.GetElement<FixedCommandKeyboardCustomization>(0);
      }
      set
      {
        this.SetElement<FixedCommandKeyboardCustomization>(0, value);
      }
    }

    public MacroKeyboardCustomization MacroKeyboardCustomization
    {
      get
      {
        return this.GetElement<MacroKeyboardCustomization>(1);
      }
      set
      {
        this.SetElement<MacroKeyboardCustomization>(1, value);
      }
    }

    public AllocatedCommandKeyboardCustomization AllocatedCommandKeyboardCustomization
    {
      get
      {
        return this.GetElement<AllocatedCommandKeyboardCustomization>(2);
      }
      set
      {
        this.SetElement<AllocatedCommandKeyboardCustomization>(2, value);
      }
    }

    public WllMacroKeyboardCustomization WllMacroKeyboardCustomization
    {
      get
      {
        return this.GetElement<WllMacroKeyboardCustomization>(3);
      }
      set
      {
        this.SetElement<WllMacroKeyboardCustomization>(3, value);
      }
    }

    public CharacterInsertion CharacterInsertion
    {
      get
      {
        return this.GetElement<CharacterInsertion>(4);
      }
      set
      {
        this.SetElement<CharacterInsertion>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "chmPrimary" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "chmSecondary" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "kcmPrimary" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "kcmSecondary" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "mask" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<KeyMapEntry>(deep);
    }
  }
}
