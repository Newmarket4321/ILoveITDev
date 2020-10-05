// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Definitions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Canvas))]
  [ChildElementInfo(typeof (TraceFormat))]
  [ChildElementInfo(typeof (Trace))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Brush))]
  [ChildElementInfo(typeof (CanvasTransform))]
  [ChildElementInfo(typeof (Context))]
  [ChildElementInfo(typeof (InkSource))]
  [ChildElementInfo(typeof (Mapping))]
  [ChildElementInfo(typeof (Timestamp))]
  [ChildElementInfo(typeof (TraceGroup))]
  [ChildElementInfo(typeof (TraceView))]
  public class Definitions : OpenXmlCompositeElement
  {
    private const string tagName = "definitions";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12740;

    public override string LocalName
    {
      get
      {
        return "definitions";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12740;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Definitions()
    {
    }

    public Definitions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Definitions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Definitions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "brush" == name)
        return (OpenXmlElement) new Brush();
      if (43 == (int) namespaceId && "canvas" == name)
        return (OpenXmlElement) new Canvas();
      if (43 == (int) namespaceId && "canvasTransform" == name)
        return (OpenXmlElement) new CanvasTransform();
      if (43 == (int) namespaceId && "context" == name)
        return (OpenXmlElement) new Context();
      if (43 == (int) namespaceId && "inkSource" == name)
        return (OpenXmlElement) new InkSource();
      if (43 == (int) namespaceId && "mapping" == name)
        return (OpenXmlElement) new Mapping();
      if (43 == (int) namespaceId && "timestamp" == name)
        return (OpenXmlElement) new Timestamp();
      if (43 == (int) namespaceId && "trace" == name)
        return (OpenXmlElement) new Trace();
      if (43 == (int) namespaceId && "traceFormat" == name)
        return (OpenXmlElement) new TraceFormat();
      if (43 == (int) namespaceId && "traceGroup" == name)
        return (OpenXmlElement) new TraceGroup();
      if (43 == (int) namespaceId && "traceView" == name)
        return (OpenXmlElement) new TraceView();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Definitions>(deep);
    }
  }
}
