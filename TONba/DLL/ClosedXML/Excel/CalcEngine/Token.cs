﻿// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Token
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel.CalcEngine
{
  internal class Token
  {
    public TKID ID;
    public TKTYPE Type;
    public object Value;

    public Token(object value, TKID id, TKTYPE type)
    {
      this.Value = value;
      this.ID = id;
      this.Type = type;
    }
  }
}