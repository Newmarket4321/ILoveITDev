// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ReservedElementTypeIds
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  internal static class ReservedElementTypeIds
  {
    internal const int OpenXmlElementId = 9000;
    internal const int OpenXmlMiscNodeId = 9001;
    internal const int OpenXmlUnknownElementId = 9002;
    internal const int AlternateContentId = 9003;
    internal const int AlternateContentChoiceId = 9004;
    internal const int AlternateContentFallbackId = 9005;
    internal const int MaxReservedId = 10000;

    internal static bool IsStrongTypedElement(this OpenXmlElement element)
    {
      return element.ElementTypeId > 10000;
    }
  }
}
