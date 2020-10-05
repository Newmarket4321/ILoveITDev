// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CategoryFilterException), FileFormatVersions.Office2013)]
  public class CategoryFilterExceptions : OpenXmlCompositeElement
  {
    private const string tagName = "categoryFilterExceptions";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13227;

    public override string LocalName
    {
      get
      {
        return "categoryFilterExceptions";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13227;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public CategoryFilterExceptions()
    {
    }

    public CategoryFilterExceptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CategoryFilterExceptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CategoryFilterExceptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "categoryFilterException" == name)
        return (OpenXmlElement) new CategoryFilterException();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CategoryFilterExceptions>(deep);
    }
  }
}
