// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLChart
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLChart : XLDrawing<IXLChart>, IXLChart, IXLDrawing<IXLChart>
  {
    private HashSet<XLChartType> Bar3DCharts = new HashSet<XLChartType>()
    {
      XLChartType.BarClustered3D,
      XLChartType.BarStacked100Percent3D,
      XLChartType.BarStacked3D,
      XLChartType.Column3D,
      XLChartType.ColumnClustered3D,
      XLChartType.ColumnStacked100Percent3D,
      XLChartType.ColumnStacked3D
    };
    private HashSet<XLChartType> HorizontalCharts = new HashSet<XLChartType>()
    {
      XLChartType.BarClustered,
      XLChartType.BarClustered3D,
      XLChartType.BarStacked,
      XLChartType.BarStacked100Percent,
      XLChartType.BarStacked100Percent3D,
      XLChartType.BarStacked3D,
      XLChartType.ConeHorizontalClustered,
      XLChartType.ConeHorizontalStacked,
      XLChartType.ConeHorizontalStacked100Percent,
      XLChartType.CylinderHorizontalClustered,
      XLChartType.CylinderHorizontalStacked,
      XLChartType.CylinderHorizontalStacked100Percent,
      XLChartType.PyramidHorizontalClustered,
      XLChartType.PyramidHorizontalStacked,
      XLChartType.PyramidHorizontalStacked100Percent
    };
    public HashSet<XLChartType> ClusteredCharts = new HashSet<XLChartType>()
    {
      XLChartType.BarClustered,
      XLChartType.BarClustered3D,
      XLChartType.ColumnClustered,
      XLChartType.ColumnClustered3D,
      XLChartType.ConeClustered,
      XLChartType.ConeHorizontalClustered,
      XLChartType.CylinderClustered,
      XLChartType.CylinderHorizontalClustered,
      XLChartType.PyramidClustered,
      XLChartType.PyramidHorizontalClustered
    };
    public HashSet<XLChartType> PercentCharts = new HashSet<XLChartType>()
    {
      XLChartType.AreaStacked100Percent,
      XLChartType.AreaStacked100Percent3D,
      XLChartType.BarStacked100Percent,
      XLChartType.BarStacked100Percent3D,
      XLChartType.ColumnStacked100Percent,
      XLChartType.ColumnStacked100Percent3D,
      XLChartType.ConeHorizontalStacked100Percent,
      XLChartType.ConeStacked100Percent,
      XLChartType.CylinderHorizontalStacked100Percent,
      XLChartType.CylinderStacked100Percent,
      XLChartType.LineStacked100Percent,
      XLChartType.LineWithMarkersStacked100Percent,
      XLChartType.PyramidHorizontalStacked100Percent,
      XLChartType.PyramidStacked100Percent
    };
    public HashSet<XLChartType> StackedCharts = new HashSet<XLChartType>()
    {
      XLChartType.AreaStacked,
      XLChartType.AreaStacked3D,
      XLChartType.BarStacked,
      XLChartType.BarStacked3D,
      XLChartType.ColumnStacked,
      XLChartType.ColumnStacked3D,
      XLChartType.ConeHorizontalStacked,
      XLChartType.ConeStacked,
      XLChartType.CylinderHorizontalStacked,
      XLChartType.CylinderStacked,
      XLChartType.LineStacked,
      XLChartType.LineWithMarkersStacked,
      XLChartType.PyramidHorizontalStacked,
      XLChartType.PyramidStacked
    };
    internal IXLWorksheet worksheet;

    public XLChart(XLWorksheet worksheet)
    {
      this.Container = (IXLChart) this;
      this.worksheet = (IXLWorksheet) worksheet;
      this.ZOrder = !worksheet.Charts.Any<IXLChart>() ? 1 : worksheet.Charts.Max<IXLChart>((Func<IXLChart, int>) (c => c.ZOrder)) + 1;
      this.ShapeId = worksheet.Workbook.ShapeIdManager.GetNext();
      this.RightAngleAxes = true;
    }

    public bool RightAngleAxes { get; set; }

    public IXLChart SetRightAngleAxes()
    {
      this.RightAngleAxes = true;
      return (IXLChart) this;
    }

    public IXLChart SetRightAngleAxes(bool rightAngleAxes)
    {
      this.RightAngleAxes = rightAngleAxes;
      return (IXLChart) this;
    }

    public XLChartType ChartType { get; set; }

    public IXLChart SetChartType(XLChartType chartType)
    {
      this.ChartType = chartType;
      return (IXLChart) this;
    }

    public XLChartTypeCategory ChartTypeCategory
    {
      get
      {
        if (this.Bar3DCharts.Contains(this.ChartType))
          return XLChartTypeCategory.Bar3D;
        throw new NotImplementedException();
      }
    }

    public XLBarOrientation BarOrientation
    {
      get
      {
        return this.HorizontalCharts.Contains(this.ChartType) ? XLBarOrientation.Horizontal : XLBarOrientation.Vertical;
      }
    }

    public XLBarGrouping BarGrouping
    {
      get
      {
        if (this.ClusteredCharts.Contains(this.ChartType))
          return XLBarGrouping.Clustered;
        if (this.PercentCharts.Contains(this.ChartType))
          return XLBarGrouping.Percent;
        return this.StackedCharts.Contains(this.ChartType) ? XLBarGrouping.Stacked : XLBarGrouping.Standard;
      }
    }
  }
}
