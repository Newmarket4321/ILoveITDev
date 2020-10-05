// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Ink
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [ChildElementInfo(typeof (Definitions))]
  [ChildElementInfo(typeof (Context))]
  [ChildElementInfo(typeof (Trace))]
  [ChildElementInfo(typeof (TraceGroup))]
  [ChildElementInfo(typeof (AnnotationXml))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Annotation))]
  [ChildElementInfo(typeof (TraceView))]
  public class Ink : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "documentID"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ink";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12714;

    public override string LocalName
    {
      get
      {
        return "ink";
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
        return 12714;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Ink.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Ink.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "documentID")]
    public StringValue DocumentId
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Ink()
    {
    }

    public Ink(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Ink(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Ink(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "annotation" == name)
        return (OpenXmlElement) new Annotation();
      if (43 == (int) namespaceId && "annotationXML" == name)
        return (OpenXmlElement) new AnnotationXml();
      if (43 == (int) namespaceId && "definitions" == name)
        return (OpenXmlElement) new Definitions();
      if (43 == (int) namespaceId && "context" == name)
        return (OpenXmlElement) new Context();
      if (43 == (int) namespaceId && "trace" == name)
        return (OpenXmlElement) new Trace();
      if (43 == (int) namespaceId && "traceGroup" == name)
        return (OpenXmlElement) new TraceGroup();
      if (43 == (int) namespaceId && "traceView" == name)
        return (OpenXmlElement) new TraceView();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "documentID" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Ink>(deep);
    }

    internal Ink(CustomXmlPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomXmlPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public void Save(CustomXmlPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }
  }
}
