﻿// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLStyle
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLStyle : IEquatable<IXLStyle>
  {
    IXLAlignment Alignment { get; set; }

    IXLBorder Border { get; set; }

    IXLFill Fill { get; set; }

    IXLFont Font { get; set; }

    IXLNumberFormat NumberFormat { get; set; }

    IXLNumberFormat DateFormat { get; }

    IXLProtection Protection { get; set; }
  }
}
