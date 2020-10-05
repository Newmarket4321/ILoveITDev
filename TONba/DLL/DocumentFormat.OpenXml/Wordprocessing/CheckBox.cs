// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.CheckBox
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (AutomaticallySizeFormField))]
  [ChildElementInfo(typeof (DefaultCheckBoxFormFieldState))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FormFieldSize))]
  [ChildElementInfo(typeof (Checked))]
  public class CheckBox : OpenXmlCompositeElement
  {
    private const string tagName = "checkBox";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11796;

    public override string LocalName
    {
      get
      {
        return "checkBox";
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
        return 11796;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CheckBox()
    {
    }

    public CheckBox(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CheckBox(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CheckBox(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "size" == name)
        return (OpenXmlElement) new FormFieldSize();
      if (23 == (int) namespaceId && "sizeAuto" == name)
        return (OpenXmlElement) new AutomaticallySizeFormField();
      if (23 == (int) namespaceId && "default" == name)
        return (OpenXmlElement) new DefaultCheckBoxFormFieldState();
      if (23 == (int) namespaceId && "checked" == name)
        return (OpenXmlElement) new Checked();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CheckBox>(deep);
    }
  }
}
