// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.XsdAnyPrefidefinedValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class XsdAnyPrefidefinedValue
  {
    public const ushort Any = 0;
    public const ushort Other = 1;
    public const ushort Local = 2;
    public const ushort TargetNamespace = 3;

    internal static string GetNamespaceString(ushort value)
    {
      switch (value)
      {
        case 0:
          return "##any";
        case 1:
          return "##other";
        case 2:
          return "##local";
        case 3:
          return "##targetNamespace";
        default:
          return string.Empty;
      }
    }
  }
}
