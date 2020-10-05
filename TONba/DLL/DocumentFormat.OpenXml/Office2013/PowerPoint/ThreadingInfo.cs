// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.ThreadingInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
  [ChildElementInfo(typeof (ParentCommentIdentifier), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class ThreadingInfo : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "timeZoneBias"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "parentCm"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 68
    };
    private const string tagName = "threadingInfo";
    private const byte tagNsId = 68;
    internal const int ElementTypeIdConst = 13327;

    public override string LocalName
    {
      get
      {
        return "threadingInfo";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 68;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13327;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ThreadingInfo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ThreadingInfo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "timeZoneBias")]
    public Int32Value TimeZoneBias
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

    public ThreadingInfo()
    {
    }

    public ThreadingInfo(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ThreadingInfo(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ThreadingInfo(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (68 == (int) namespaceId && "parentCm" == name)
        return (OpenXmlElement) new ParentCommentIdentifier();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ThreadingInfo.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ThreadingInfo.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ParentCommentIdentifier ParentCommentIdentifier
    {
      get
      {
        return this.GetElement<ParentCommentIdentifier>(0);
      }
      set
      {
        this.SetElement<ParentCommentIdentifier>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "timeZoneBias" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ThreadingInfo>(deep);
    }
  }
}
