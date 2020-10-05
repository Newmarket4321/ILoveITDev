// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.MailMergeRecipientDataPartTypeInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class MailMergeRecipientDataPartTypeInfo
  {
    internal static string GetContentType(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
    {
      switch (mailMergeRecipientDataPartType)
      {
        case MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData:
          return "application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml";
        case MailMergeRecipientDataPartType.MsWordMailMergeRecipientData:
          return "application/vnd.ms-word.mailMergeRecipientData+xml";
        default:
          throw new ArgumentOutOfRangeException(nameof (mailMergeRecipientDataPartType));
      }
    }

    internal static string GetTargetExtension(MailMergeRecipientDataPartType mailMergeRecipientDataPartType)
    {
      return ".xml";
    }
  }
}
