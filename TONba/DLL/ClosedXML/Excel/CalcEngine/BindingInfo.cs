// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.BindingInfo
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;
using System.Reflection;

namespace ClosedXML.Excel.CalcEngine
{
  internal class BindingInfo
  {
    public BindingInfo(string member, List<Expression> parms)
    {
      this.Name = member;
      this.Parms = parms;
    }

    public string Name { get; set; }

    public PropertyInfo PropertyInfo { get; set; }

    public PropertyInfo PropertyInfoItem { get; set; }

    public List<Expression> Parms { get; set; }
  }
}
