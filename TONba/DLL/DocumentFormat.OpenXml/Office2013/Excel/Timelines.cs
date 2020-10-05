// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.Timelines
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Timeline), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class Timelines : OpenXmlPartRootElement
  {
    private const string tagName = "timelines";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13386;

    public override string LocalName
    {
      get
      {
        return "timelines";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13386;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal Timelines(TimeLinePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(TimeLinePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public TimeLinePart TimeLinePart
    {
      get
      {
        return this.OpenXmlPart as TimeLinePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Timelines(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Timelines(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Timelines(string outerXml)
      : base(outerXml)
    {
    }

    public Timelines()
    {
    }

    public void Save(TimeLinePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "timeline" == name)
        return (OpenXmlElement) new Timeline();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Timelines>(deep);
    }
  }
}
