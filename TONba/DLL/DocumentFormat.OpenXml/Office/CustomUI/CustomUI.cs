// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.CustomUI
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Ribbon))]
  [ChildElementInfo(typeof (RepurposedCommands))]
  public class CustomUI : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "onLoad",
      "loadImage"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[2]
    {
      "commands",
      "ribbon"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 34,
      (byte) 34
    };
    private const string tagName = "customUI";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12669;

    public override string LocalName
    {
      get
      {
        return "customUI";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 34;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12669;
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
        return DocumentFormat.OpenXml.Office.CustomUI.CustomUI.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office.CustomUI.CustomUI.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "onLoad")]
    public StringValue OnLoad
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

    [SchemaAttr(0, "loadImage")]
    public StringValue LoadImage
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public CustomUI()
    {
    }

    public CustomUI(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomUI(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomUI(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "commands" == name)
        return (OpenXmlElement) new RepurposedCommands();
      if (34 == (int) namespaceId && "ribbon" == name)
        return (OpenXmlElement) new Ribbon();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office.CustomUI.CustomUI.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office.CustomUI.CustomUI.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RepurposedCommands RepurposedCommands
    {
      get
      {
        return this.GetElement<RepurposedCommands>(0);
      }
      set
      {
        this.SetElement<RepurposedCommands>(0, value);
      }
    }

    public Ribbon Ribbon
    {
      get
      {
        return this.GetElement<Ribbon>(1);
      }
      set
      {
        this.SetElement<Ribbon>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "onLoad" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "loadImage" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office.CustomUI.CustomUI>(deep);
    }

    internal CustomUI(CustomUIPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomUIPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public void Save(CustomUIPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    public CustomUIPart CustomUIPart
    {
      get
      {
        return this.OpenXmlPart as CustomUIPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }
  }
}
