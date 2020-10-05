// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2013.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SdtContentEquation))]
  [ChildElementInfo(typeof (SdtRepeatedSectionItem), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtAlias))]
  [ChildElementInfo(typeof (Lock))]
  [ChildElementInfo(typeof (SdtPlaceholder))]
  [ChildElementInfo(typeof (ShowingPlaceholder))]
  [ChildElementInfo(typeof (DataBinding))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Word.DataBinding), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TemporarySdt))]
  [ChildElementInfo(typeof (SdtId))]
  [ChildElementInfo(typeof (Tag))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Word.Color), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Appearance), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionLinked), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionCreated), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RunProperties))]
  [ChildElementInfo(typeof (SdtContentComboBox))]
  [ChildElementInfo(typeof (SdtContentDate))]
  [ChildElementInfo(typeof (SdtContentDocPartObject))]
  [ChildElementInfo(typeof (SdtContentDocPartList))]
  [ChildElementInfo(typeof (SdtContentDropDownList))]
  [ChildElementInfo(typeof (SdtContentPicture))]
  [ChildElementInfo(typeof (SdtContentRichText))]
  [ChildElementInfo(typeof (SdtContentText))]
  [ChildElementInfo(typeof (SdtContentCitation))]
  [ChildElementInfo(typeof (SdtContentGroup))]
  [ChildElementInfo(typeof (SdtContentBibliography))]
  [ChildElementInfo(typeof (EntityPickerEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtContentCheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtRepeatedSection), FileFormatVersions.Office2013)]
  public class SdtProperties : OpenXmlCompositeElement
  {
    private const string tagName = "sdtPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11832;

    public override string LocalName
    {
      get
      {
        return "sdtPr";
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
        return 11832;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SdtProperties()
    {
    }

    public SdtProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (23 == (int) namespaceId && "alias" == name)
        return (OpenXmlElement) new SdtAlias();
      if (23 == (int) namespaceId && "lock" == name)
        return (OpenXmlElement) new Lock();
      if (23 == (int) namespaceId && "placeholder" == name)
        return (OpenXmlElement) new SdtPlaceholder();
      if (23 == (int) namespaceId && "showingPlcHdr" == name)
        return (OpenXmlElement) new ShowingPlaceholder();
      if (23 == (int) namespaceId && "dataBinding" == name)
        return (OpenXmlElement) new DataBinding();
      if (69 == (int) namespaceId && "dataBinding" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Word.DataBinding();
      if (23 == (int) namespaceId && "temporary" == name)
        return (OpenXmlElement) new TemporarySdt();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlElement) new SdtId();
      if (23 == (int) namespaceId && "tag" == name)
        return (OpenXmlElement) new Tag();
      if (69 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Word.Color();
      if (69 == (int) namespaceId && "appearance" == name)
        return (OpenXmlElement) new Appearance();
      if (69 == (int) namespaceId && "webExtensionLinked" == name)
        return (OpenXmlElement) new WebExtensionLinked();
      if (69 == (int) namespaceId && "webExtensionCreated" == name)
        return (OpenXmlElement) new WebExtensionCreated();
      if (23 == (int) namespaceId && "equation" == name)
        return (OpenXmlElement) new SdtContentEquation();
      if (23 == (int) namespaceId && "comboBox" == name)
        return (OpenXmlElement) new SdtContentComboBox();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlElement) new SdtContentDate();
      if (23 == (int) namespaceId && "docPartObj" == name)
        return (OpenXmlElement) new SdtContentDocPartObject();
      if (23 == (int) namespaceId && "docPartList" == name)
        return (OpenXmlElement) new SdtContentDocPartList();
      if (23 == (int) namespaceId && "dropDownList" == name)
        return (OpenXmlElement) new SdtContentDropDownList();
      if (23 == (int) namespaceId && "picture" == name)
        return (OpenXmlElement) new SdtContentPicture();
      if (23 == (int) namespaceId && "richText" == name)
        return (OpenXmlElement) new SdtContentRichText();
      if (23 == (int) namespaceId && "text" == name)
        return (OpenXmlElement) new SdtContentText();
      if (23 == (int) namespaceId && "citation" == name)
        return (OpenXmlElement) new SdtContentCitation();
      if (23 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new SdtContentGroup();
      if (23 == (int) namespaceId && "bibliography" == name)
        return (OpenXmlElement) new SdtContentBibliography();
      if (52 == (int) namespaceId && "entityPicker" == name)
        return (OpenXmlElement) new EntityPickerEmpty();
      if (52 == (int) namespaceId && "checkbox" == name)
        return (OpenXmlElement) new SdtContentCheckBox();
      if (69 == (int) namespaceId && "repeatingSection" == name)
        return (OpenXmlElement) new SdtRepeatedSection();
      if (69 == (int) namespaceId && "repeatingSectionItem" == name)
        return (OpenXmlElement) new SdtRepeatedSectionItem();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtProperties>(deep);
    }
  }
}
