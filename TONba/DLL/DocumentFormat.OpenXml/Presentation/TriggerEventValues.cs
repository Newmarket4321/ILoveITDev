// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TriggerEventValues
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public enum TriggerEventValues
  {
    [EnumString("none")] None,
    [EnumString("onBegin")] OnBegin,
    [EnumString("onEnd")] OnEnd,
    [EnumString("begin")] Begin,
    [EnumString("end")] End,
    [EnumString("onClick")] OnClick,
    [EnumString("onDblClick")] OnDoubleClick,
    [EnumString("onMouseOver")] OnMouseOver,
    [EnumString("onMouseOut")] OnMouseOut,
    [EnumString("onNext")] OnNext,
    [EnumString("onPrev")] OnPrevious,
    [EnumString("onStopAudio")] OnStopAudio,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("onMediaBookmark")] OnMediaBookmark,
  }
}
