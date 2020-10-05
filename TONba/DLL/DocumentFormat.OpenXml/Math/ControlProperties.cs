// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.ControlProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.RunProperties))]
  [ChildElementInfo(typeof (DeletedMathControl))]
  [ChildElementInfo(typeof (MoveFromMathControl))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (InsertedMathControl))]
  [ChildElementInfo(typeof (MoveToMathControl))]
  public class ControlProperties : OpenXmlCompositeElement
  {
    private const string tagName = "ctrlPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10937;

    public override string LocalName
    {
      get
      {
        return "ctrlPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10937;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ControlProperties()
    {
    }

    public ControlProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ControlProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ControlProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.RunProperties();
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new InsertedMathControl();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new DeletedMathControl();
      if (23 == (int) namespaceId && "moveFrom" == name)
        return (OpenXmlElement) new MoveFromMathControl();
      if (23 == (int) namespaceId && "moveTo" == name)
        return (OpenXmlElement) new MoveToMathControl();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ControlProperties>(deep);
    }
  }
}
