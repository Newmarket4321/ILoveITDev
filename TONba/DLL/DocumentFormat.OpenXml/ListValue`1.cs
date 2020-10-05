// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ListValue`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class ListValue<T> : OpenXmlSimpleType where T : OpenXmlSimpleType, new()
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private const string _listSeparator = " ";
    private ObservableCollection<T> _list;

    public ListValue()
    {
    }

    public ListValue(IEnumerable<T> list)
    {
      if (list == null)
        throw new ArgumentNullException(nameof (list));
      this._list = new ObservableCollection<T>();
      this._list.CollectionChanged += new NotifyCollectionChangedEventHandler(this.CollectionChanged);
      foreach (T obj in list)
        this._list.Add(obj.Clone() as T);
    }

    public ListValue(ListValue<T> source)
      : this((IEnumerable<T>) source.Items)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
    }

    public override bool HasValue
    {
      get
      {
        if (this._list == null && !string.IsNullOrEmpty(this.TextValue))
          this.TryParse();
        if (this._list == null)
          return false;
        return this._list.Count > 0;
      }
    }

    public ICollection<T> Items
    {
      get
      {
        if (this._list == null)
        {
          if (!string.IsNullOrEmpty(this.TextValue))
          {
            this.Parse();
          }
          else
          {
            this._list = new ObservableCollection<T>();
            this._list.CollectionChanged += new NotifyCollectionChangedEventHandler(this.CollectionChanged);
          }
        }
        return (ICollection<T>) this._list;
      }
    }

    internal override void Parse()
    {
      this._list = new ObservableCollection<T>();
      this._list.CollectionChanged += new NotifyCollectionChangedEventHandler(this.CollectionChanged);
      if (string.IsNullOrEmpty(this.TextValue))
        return;
      foreach (string str in this.TextValue.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries))
      {
        T instance = Activator.CreateInstance<T>();
        instance.InnerText = str;
        this._list.Add(instance);
      }
    }

    internal override bool TryParse()
    {
      if (string.IsNullOrEmpty(this.TextValue))
        return false;
      string[] strArray = this.TextValue.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
      ObservableCollection<T> observableCollection = new ObservableCollection<T>();
      foreach (string str in strArray)
      {
        T instance = Activator.CreateInstance<T>();
        instance.InnerText = str;
        observableCollection.Add(instance);
      }
      this._list = observableCollection;
      this._list.CollectionChanged += new NotifyCollectionChangedEventHandler(this.CollectionChanged);
      return true;
    }

    public override string InnerText
    {
      get
      {
        if (this.TextValue == null && this._list != null)
        {
          StringBuilder stringBuilder = new StringBuilder();
          string str = string.Empty;
          foreach (T obj in (Collection<T>) this._list)
          {
            if ((object) obj != null)
            {
              stringBuilder.Append(str);
              stringBuilder.Append(obj.ToString());
              str = " ";
            }
          }
          this.TextValue = stringBuilder.ToString();
        }
        return this.TextValue;
      }
      set
      {
        this.TextValue = value;
        this._list = (ObservableCollection<T>) null;
      }
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new ListValue<T>(this);
    }

    private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
      this.TextValue = (string) null;
    }

    internal override IEnumerable<OpenXmlSimpleType> GetListItems()
    {
      foreach (T obj in (IEnumerable<T>) this.Items)
        yield return (OpenXmlSimpleType) obj;
    }
  }
}
