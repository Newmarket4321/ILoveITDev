// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.MailMergeRecipients
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SingleDataSourceRecord))]
  public class MailMergeRecipients : OpenXmlPartRootElement
  {
    private const string tagName = "recipients";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12611;

    public override string LocalName
    {
      get
      {
        return "recipients";
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
        return 12611;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MailMergeRecipients()
    {
    }

    public MailMergeRecipients(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MailMergeRecipients(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MailMergeRecipients(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "recipientData" == name)
        return (OpenXmlElement) new SingleDataSourceRecord();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MailMergeRecipients>(deep);
    }

    internal MailMergeRecipients(MailMergeRecipientDataPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(MailMergeRecipientDataPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public void Save(MailMergeRecipientDataPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }
  }
}
