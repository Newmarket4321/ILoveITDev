// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeTypeListType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ExclusiveTimeNode))]
  [ChildElementInfo(typeof (AnimateEffect))]
  [ChildElementInfo(typeof (Video))]
  [ChildElementInfo(typeof (ParallelTimeNode))]
  [ChildElementInfo(typeof (SequenceTimeNode))]
  [ChildElementInfo(typeof (AnimateMotion))]
  [ChildElementInfo(typeof (Animate))]
  [ChildElementInfo(typeof (AnimateColor))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AnimateScale))]
  [ChildElementInfo(typeof (AnimateRotation))]
  [ChildElementInfo(typeof (Command))]
  [ChildElementInfo(typeof (SetBehavior))]
  [ChildElementInfo(typeof (Audio))]
  public abstract class TimeTypeListType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "par" == name)
        return (OpenXmlElement) new ParallelTimeNode();
      if (24 == (int) namespaceId && "seq" == name)
        return (OpenXmlElement) new SequenceTimeNode();
      if (24 == (int) namespaceId && "excl" == name)
        return (OpenXmlElement) new ExclusiveTimeNode();
      if (24 == (int) namespaceId && "anim" == name)
        return (OpenXmlElement) new Animate();
      if (24 == (int) namespaceId && "animClr" == name)
        return (OpenXmlElement) new AnimateColor();
      if (24 == (int) namespaceId && "animEffect" == name)
        return (OpenXmlElement) new AnimateEffect();
      if (24 == (int) namespaceId && "animMotion" == name)
        return (OpenXmlElement) new AnimateMotion();
      if (24 == (int) namespaceId && "animRot" == name)
        return (OpenXmlElement) new AnimateRotation();
      if (24 == (int) namespaceId && "animScale" == name)
        return (OpenXmlElement) new AnimateScale();
      if (24 == (int) namespaceId && "cmd" == name)
        return (OpenXmlElement) new Command();
      if (24 == (int) namespaceId && "set" == name)
        return (OpenXmlElement) new SetBehavior();
      if (24 == (int) namespaceId && "audio" == name)
        return (OpenXmlElement) new Audio();
      if (24 == (int) namespaceId && "video" == name)
        return (OpenXmlElement) new Video();
      return (OpenXmlElement) null;
    }

    protected TimeTypeListType()
    {
    }

    protected TimeTypeListType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TimeTypeListType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TimeTypeListType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
