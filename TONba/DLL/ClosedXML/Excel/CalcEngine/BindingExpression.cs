// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.BindingExpression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace ClosedXML.Excel.CalcEngine
{
  internal class BindingExpression : Expression
  {
    private ClosedXML.Excel.CalcEngine.CalcEngine _ce;
    private CultureInfo _ci;
    private List<BindingInfo> _bindingPath;

    internal BindingExpression(ClosedXML.Excel.CalcEngine.CalcEngine engine, List<BindingInfo> bindingPath, CultureInfo ci)
    {
      this._ce = engine;
      this._bindingPath = bindingPath;
      this._ci = ci;
    }

    public override object Evaluate()
    {
      return this.GetValue(this._ce.DataContext);
    }

    private object GetValue(object obj)
    {
      if (obj != null)
      {
        foreach (BindingInfo bindingInfo in this._bindingPath)
        {
          if (bindingInfo.PropertyInfo == (PropertyInfo) null)
            bindingInfo.PropertyInfo = obj.GetType().GetProperty(bindingInfo.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
          try
          {
            obj = bindingInfo.PropertyInfo.GetValue(obj, (object[]) null);
          }
          catch
          {
            bindingInfo.PropertyInfo = obj.GetType().GetProperty(bindingInfo.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            bindingInfo.PropertyInfoItem = (PropertyInfo) null;
            obj = bindingInfo.PropertyInfo.GetValue(obj, (object[]) null);
          }
          if (bindingInfo.Parms != null && bindingInfo.Parms.Count > 0)
          {
            if (bindingInfo.PropertyInfoItem == (PropertyInfo) null)
              bindingInfo.PropertyInfoItem = obj.GetType().GetProperty("Item", BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            ParameterInfo[] indexParameters = bindingInfo.PropertyInfoItem.GetIndexParameters();
            List<object> objectList = new List<object>();
            for (int index = 0; index < indexParameters.Length; ++index)
            {
              object obj1 = Convert.ChangeType(bindingInfo.Parms[index].Evaluate(), indexParameters[index].ParameterType, (IFormatProvider) this._ci);
              objectList.Add(obj1);
            }
            obj = bindingInfo.PropertyInfoItem.GetValue(obj, objectList.ToArray());
          }
        }
      }
      return obj;
    }
  }
}
