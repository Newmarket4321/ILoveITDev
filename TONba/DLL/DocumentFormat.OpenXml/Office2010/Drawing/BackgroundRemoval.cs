// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ForegroundMark), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackgroundMark), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class BackgroundRemoval : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "t",
      "b",
      "l",
      "r"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "backgroundRemoval";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12820;

    public override string LocalName
    {
      get
      {
        return "backgroundRemoval";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12820;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return BackgroundRemoval.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BackgroundRemoval.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "t")]
    public Int32Value MarqueeTop
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "b")]
    public Int32Value MarqueeBottom
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "l")]
    public Int32Value MarqueeLeft
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "r")]
    public Int32Value MarqueeRight
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public BackgroundRemoval()
    {
    }

    public BackgroundRemoval(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BackgroundRemoval(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BackgroundRemoval(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "foregroundMark" == name)
        return (OpenXmlElement) new ForegroundMark();
      if (48 == (int) namespaceId && "backgroundMark" == name)
        return (OpenXmlElement) new BackgroundMark();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "b" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "l" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BackgroundRemoval>(deep);
    }
  }
}
