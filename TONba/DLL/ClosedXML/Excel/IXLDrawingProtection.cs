// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingProtection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingProtection
  {
    bool Locked { get; set; }

    bool LockText { get; set; }

    IXLDrawingStyle SetLocked();

    IXLDrawingStyle SetLocked(bool value);

    IXLDrawingStyle SetLockText();

    IXLDrawingStyle SetLockText(bool value);
  }
}
