using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.Charts
{
    /// <summary>
    /// Base class for handling LiveCharts charts. <para/>
    /// Intended to be used as a base class for classes which implement a singleton pattern. In the derived class, implement the following:
    /// <code>
    /// <![CDATA[
    /// // "Static" constructor used to instantiate singleton
    /// private DerivedChartClass() : base() { }
    /// // Create singleton
    /// private static readonly Lazy<DerivedChartClass> lazy = new Lazy<DerivedChartClass>(() => new DerivedChartClass());
    /// public static DerivedChartClass Instance => lazy.Value;
    /// ]]>
    /// </code>
    /// </summary>
    public class Chart
    {
        protected static LiveChartsCore.SkiaSharpView.Maui.CartesianChart lvcchart;
        /// <summary>
        /// The LVCharts object defined in the page XAML where the chart appears. Assign this value in that page's code-behind.
        /// </summary>
        public virtual LiveChartsCore.SkiaSharpView.Maui.CartesianChart LVCChart
        {
            get { return lvcchart; }
            set { lvcchart = value; }
        }

        protected static LiveChartsCore.Measure.Margin margin;
        public virtual LiveChartsCore.Measure.Margin Margin {
            get { return margin; }
            set { margin = value; }
        }

        protected static ISeries[] series { get; set; }
        public virtual ISeries[] Series {
            get { return series; }
            set { series = value; }
        }

        protected Chart()
        {
            Margin = new LiveChartsCore.Measure.Margin(40, 20, 600, 40);
            Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new List<double>(),
                    Fill = null
                }
            };
        }

        public virtual void AddSeries(IEnumerable<double> values = null, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> fill = null)
        {
            values ??= Enumerable.Empty<double>();
            Series = Series.Append(new LineSeries<double>
            {
                Values = values.ToList(),
                Fill = fill
            }).ToArray();
            UpdateChart();
        }
        public virtual void AddValue(double value, int series = 0)
        {
            ((List<double>)Series[series].Values).Add(value);
            UpdateChart();
        }
        public virtual void AddValues(IEnumerable<double> values, int series = 0)
        {
            ((List<double>)Series[series].Values).AddRange(values);
            UpdateChart();
        }

        public virtual void UpdateChart()
        {
            if (LVCChart != null)
            {
                LVCChart.CoreChart.Update();
            }
        }
    }
}
