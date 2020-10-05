// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.ExpressionCache
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine
{
  internal class ExpressionCache
  {
    private Dictionary<string, WeakReference> _dct;
    private ClosedXML.Excel.CalcEngine.CalcEngine _ce;
    private int _hitCount;

    public ExpressionCache(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      this._ce = ce;
      this._dct = new Dictionary<string, WeakReference>();
    }

    public Expression this[string expression]
    {
      get
      {
        WeakReference weakReference;
        Expression target;
        if (this._dct.TryGetValue(expression, out weakReference) && weakReference.IsAlive)
        {
          target = weakReference.Target as Expression;
        }
        else
        {
          if (weakReference != null && this._dct.Count > 100 && this._hitCount++ > 100)
          {
            this.RemoveDeadReferences();
            this._hitCount = 0;
          }
          target = this._ce.Parse(expression);
          this._dct[expression] = new WeakReference((object) target);
        }
        return target;
      }
    }

    private void RemoveDeadReferences()
    {
      bool flag = false;
      while (!flag)
      {
        flag = true;
        foreach (string key in this._dct.Keys)
        {
          if (!this._dct[key].IsAlive)
          {
            this._dct.Remove(key);
            flag = false;
            break;
          }
        }
      }
    }
  }
}
