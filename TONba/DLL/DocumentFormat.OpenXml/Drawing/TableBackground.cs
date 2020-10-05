// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableBackground
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (FillProperties))]
  [ChildElementInfo(typeof (EffectReference))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EffectPropertiesType))]
  [ChildElementInfo(typeof (FillReference))]
  public class TableBackground : OpenXmlCompositeElement
  {
    private const string tagName = "tblBg";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10274;

    public override string LocalName
    {
      get
      {
        return "tblBg";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10274;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableBackground()
    {
    }

    public TableBackground(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableBackground(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableBackground(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new FillProperties();
      if (10 == (int) namespaceId && "fillRef" == name)
        return (OpenXmlElement) new FillReference();
      if (10 == (int) namespaceId && "effect" == name)
        return (OpenXmlElement) new EffectPropertiesType();
      if (10 == (int) namespaceId && "effectRef" == name)
        return (OpenXmlElement) new EffectReference();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableBackground>(deep);
    }
  }
}
