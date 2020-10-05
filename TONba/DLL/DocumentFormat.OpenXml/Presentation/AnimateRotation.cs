// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.AnimateRotation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonBehavior))]
  public class AnimateRotation : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "by",
      "from",
      "to",
      "bounceEnd"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 49
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "cBhvr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "animRot";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12266;

    public override string LocalName
    {
      get
      {
        return "animRot";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12266;
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
        return AnimateRotation.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimateRotation.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "by")]
    public Int32Value By
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

    [SchemaAttr(0, "from")]
    public Int32Value From
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

    [SchemaAttr(0, "to")]
    public Int32Value To
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

    [SchemaAttr(49, "bounceEnd")]
    public Int32Value BounceEnd
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

    public AnimateRotation()
    {
    }

    public AnimateRotation(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnimateRotation(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnimateRotation(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnimateRotation.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnimateRotation.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonBehavior CommonBehavior
    {
      get
      {
        return this.GetElement<CommonBehavior>(0);
      }
      set
      {
        this.SetElement<CommonBehavior>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "by" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "from" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "to" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (49 == (int) namespaceId && "bounceEnd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimateRotation>(deep);
    }
  }
}
