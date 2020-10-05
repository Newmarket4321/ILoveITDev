// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWorkbookProperties
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public class XLWorkbookProperties
  {
    public XLWorkbookProperties()
    {
      this.Company = (string) null;
      this.Manager = (string) null;
    }

    public string Author { get; set; }

    public string Title { get; set; }

    public string Subject { get; set; }

    public string Category { get; set; }

    public string Keywords { get; set; }

    public string Comments { get; set; }

    public string Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string LastModifiedBy { get; set; }

    public string Company { get; set; }

    public string Manager { get; set; }
  }
}
