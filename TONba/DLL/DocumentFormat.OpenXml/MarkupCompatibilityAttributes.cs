// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.MarkupCompatibilityAttributes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml
{
  public class MarkupCompatibilityAttributes
  {
    internal static string MCPrefix = NamespaceIdMap.GetNamespacePrefix(NamespaceIdMap.GetNamespaceId(AlternateContent.MarkupCompatibilityNamespace));

    public StringValue Ignorable { get; set; }

    public StringValue ProcessContent { get; set; }

    public StringValue PreserveElements { get; set; }

    public StringValue PreserveAttributes { get; set; }

    public StringValue MustUnderstand { get; set; }
  }
}
