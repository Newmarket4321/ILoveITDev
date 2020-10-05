// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.MatrixRow
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  public class MatrixRow : OpenXmlCompositeElement
  {
    private const string tagName = "mr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10988;

    public override string LocalName
    {
      get
      {
        return "mr";
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
        return 10988;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MatrixRow()
    {
    }

    public MatrixRow(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MatrixRow(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MatrixRow(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MatrixRow>(deep);
    }
  }
}
