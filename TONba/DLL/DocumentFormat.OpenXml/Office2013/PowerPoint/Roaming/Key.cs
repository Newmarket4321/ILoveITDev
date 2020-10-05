// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class Key : OpenXmlLeafTextElement
  {
    private const string tagName = "key";
    private const byte tagNsId = 76;
    internal const int ElementTypeIdConst = 13438;

    public override string LocalName
    {
      get
      {
        return "key";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 76;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13438;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public Key()
    {
    }

    public Key(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Key>(deep);
    }
  }
}
