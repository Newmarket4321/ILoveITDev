// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [ChildElementInfo(typeof (Toolbars))]
  [ChildElementInfo(typeof (AllocatedCommands))]
  [ChildElementInfo(typeof (KeyMapCustomizations))]
  [ChildElementInfo(typeof (MismatchedKeyMapCustomization))]
  [GeneratedCode("DomGen", "2.0")]
  public class TemplateCommandGroup : OpenXmlPartRootElement
  {
    private const string tagName = "tcg";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12608;

    public override string LocalName
    {
      get
      {
        return "tcg";
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
        return 12608;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal TemplateCommandGroup(CustomizationPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomizationPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CustomizationPart CustomizationPart
    {
      get
      {
        return this.OpenXmlPart as CustomizationPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public TemplateCommandGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TemplateCommandGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TemplateCommandGroup(string outerXml)
      : base(outerXml)
    {
    }

    public TemplateCommandGroup()
    {
    }

    public void Save(CustomizationPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "keymaps" == name)
        return (OpenXmlElement) new KeyMapCustomizations();
      if (33 == (int) namespaceId && "keymapsBad" == name)
        return (OpenXmlElement) new MismatchedKeyMapCustomization();
      if (33 == (int) namespaceId && "toolbars" == name)
        return (OpenXmlElement) new Toolbars();
      if (33 == (int) namespaceId && "acds" == name)
        return (OpenXmlElement) new AllocatedCommands();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TemplateCommandGroup>(deep);
    }
  }
}
