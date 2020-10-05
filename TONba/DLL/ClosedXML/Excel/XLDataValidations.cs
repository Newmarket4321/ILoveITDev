// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDataValidations
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLDataValidations : IXLDataValidations, IEnumerable<IXLDataValidation>, IEnumerable
  {
    private readonly List<IXLDataValidation> _dataValidations = new List<IXLDataValidation>();

    public void Add(IXLDataValidation dataValidation)
    {
      this._dataValidations.Add(dataValidation);
    }

    public IEnumerator<IXLDataValidation> GetEnumerator()
    {
      return (IEnumerator<IXLDataValidation>) this._dataValidations.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public bool ContainsSingle(IXLRange range)
    {
      int num = 0;
      foreach (IXLDataValidation xlDataValidation in this._dataValidations.Where<IXLDataValidation>((Func<IXLDataValidation, bool>) (dv => dv.Ranges.Contains(range))))
      {
        ++num;
        if (num > 1)
          return false;
      }
      return num == 1;
    }

    public void Delete(IXLDataValidation dataValidation)
    {
      this._dataValidations.RemoveAll((Predicate<IXLDataValidation>) (dv => dv.Ranges.Equals((object) dataValidation.Ranges)));
    }

    public void Delete(IXLRange range)
    {
      this._dataValidations.RemoveAll((Predicate<IXLDataValidation>) (dv => dv.Ranges.Contains(range)));
    }
  }
}
