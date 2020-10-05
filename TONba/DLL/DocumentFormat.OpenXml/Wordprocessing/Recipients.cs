// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Recipients
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (RecipientData))]
  [GeneratedCode("DomGen", "2.0")]
  public class Recipients : OpenXmlPartRootElement
  {
    private const string tagName = "recipients";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11753;

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
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11753;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Recipients()
    {
    }

    public Recipients(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Recipients(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Recipients(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "recipientData" == name)
        return (OpenXmlElement) new RecipientData();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Recipients>(deep);
    }

    internal Recipients(MailMergeRecipientDataPart ownerPart)
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
