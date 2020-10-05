// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public enum TextDirectionValues
  {
    [EnumString("lrTb")] LefToRightTopToBottom,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("tb")] LeftToRightTopToBottom2010,
    [EnumString("tbRl")] TopToBottomRightToLeft,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("rl")] TopToBottomRightToLeft2010,
    [EnumString("btLr")] BottomToTopLeftToRight,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("lr")] BottomToTopLeftToRight2010,
    [EnumString("lrTbV")] LefttoRightTopToBottomRotated,
    [EnumString("tbV"), OfficeAvailability(FileFormatVersions.Office2010)] LeftToRightTopToBottomRotated2010,
    [EnumString("tbRlV")] TopToBottomRightToLeftRotated,
    [EnumString("rlV"), OfficeAvailability(FileFormatVersions.Office2010)] TopToBottomRightToLeftRotated2010,
    [EnumString("tbLrV")] TopToBottomLeftToRightRotated,
    [OfficeAvailability(FileFormatVersions.Office2010), EnumString("lrV")] TopToBottomLeftToRightRotated2010,
  }
}
