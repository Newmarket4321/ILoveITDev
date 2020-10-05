// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FormFieldData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ExitMacro))]
  [ChildElementInfo(typeof (EntryMacro))]
  [ChildElementInfo(typeof (HelpText))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FormFieldName))]
  [ChildElementInfo(typeof (Enabled))]
  [ChildElementInfo(typeof (CalculateOnExit))]
  [ChildElementInfo(typeof (StatusText))]
  [ChildElementInfo(typeof (CheckBox))]
  [ChildElementInfo(typeof (DropDownListFormField))]
  [ChildElementInfo(typeof (TextInput))]
  public class FormFieldData : OpenXmlCompositeElement
  {
    private const string tagName = "ffData";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11788;

    public override string LocalName
    {
      get
      {
        return "ffData";
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
        return 11788;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FormFieldData()
    {
    }

    public FormFieldData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FormFieldData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FormFieldData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new FormFieldName();
      if (23 == (int) namespaceId && "enabled" == name)
        return (OpenXmlElement) new Enabled();
      if (23 == (int) namespaceId && "calcOnExit" == name)
        return (OpenXmlElement) new CalculateOnExit();
      if (23 == (int) namespaceId && "entryMacro" == name)
        return (OpenXmlElement) new EntryMacro();
      if (23 == (int) namespaceId && "exitMacro" == name)
        return (OpenXmlElement) new ExitMacro();
      if (23 == (int) namespaceId && "helpText" == name)
        return (OpenXmlElement) new HelpText();
      if (23 == (int) namespaceId && "statusText" == name)
        return (OpenXmlElement) new StatusText();
      if (23 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new CheckBox();
      if (23 == (int) namespaceId && "ddList" == name)
        return (OpenXmlElement) new DropDownListFormField();
      if (23 == (int) namespaceId && "textInput" == name)
        return (OpenXmlElement) new TextInput();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FormFieldData>(deep);
    }
  }
}
