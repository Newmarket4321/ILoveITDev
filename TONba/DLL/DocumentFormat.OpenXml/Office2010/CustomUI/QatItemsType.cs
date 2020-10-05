// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.QatItemsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ControlCloneQat), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Separator), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public abstract class QatItemsType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new ControlCloneQat();
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new ButtonRegular();
      if (57 == (int) namespaceId && "separator" == name)
        return (OpenXmlElement) new Separator();
      return (OpenXmlElement) null;
    }

    protected QatItemsType()
    {
    }

    protected QatItemsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected QatItemsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected QatItemsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
