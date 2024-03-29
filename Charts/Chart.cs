﻿using LiveChartsCore;
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
        // private static List<Chart> Charts = new();

        /// <summary>
        /// The LVCharts object defined in the page XAML where the chart appears. Assign this value in that page's code-behind.
        /// </summary>
        public virtual LiveChartsCore.SkiaSharpView.Maui.CartesianChart LVCChart { get; set; }

        public virtual LiveChartsCore.Measure.Margin Margin { get; set; }

        public virtual ISeries[] Series { get; set; }

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

            //Charts.Add(this);
            PageLoaded += OnPageLoaded;
            DisplayInfoChanged += OnDisplayInfoChanged;
            WindowInfoChanged += OnWindowInfoChanged;
        }

        internal virtual void AddSeries(IEnumerable<double> values = null, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> fill = null)
        {
            values ??= Enumerable.Empty<double>();
            Series = Series.Append(new LineSeries<double>
            {
                Values = values.ToList(),
                Fill = fill
            }).ToArray();
            UpdateChart();
        }
        internal virtual void AddValue(double value, int series = 0)
        {
            ((List<double>)Series[series].Values).Add(value);
            UpdateChart();
        }
        internal virtual void AddValues(IEnumerable<double> values, int series = 0)
        {
            ((List<double>)Series[series].Values).AddRange(values);
            UpdateChart();
        }

        protected virtual void UpdateChart()
        {
            if (LVCChart != null)
            {
                LVCChart.CoreChart.Update();
            }
        }


        internal static event EventHandler PageLoaded;
        internal static void OnPageLoaded_All(object sender, EventArgs e) { PageLoaded?.Invoke(sender, e); }
        internal virtual void OnPageLoaded(object sender, EventArgs e) { CalculateMargin(); }
        
        internal static event EventHandler DisplayInfoChanged;
        internal static void OnDisplayInfoChanged_All(object sender, EventArgs e) { DisplayInfoChanged?.Invoke(sender, e); }
        internal virtual void OnDisplayInfoChanged(object sender, EventArgs e) { CalculateMargin(); }

        internal static event EventHandler WindowInfoChanged;
        internal static void OnWindowInfoChanged_All(object sender, EventArgs e) { WindowInfoChanged?.Invoke(sender, e); }
        internal virtual void OnWindowInfoChanged(object sender, EventArgs e) { CalculateMargin(); }

        protected virtual void CalculateMargin()
        {
            
            var newMargin = new LiveChartsCore.Measure.Margin();
            //TODO: Update margins based on density etc.
            if (newMargin != Margin)
            {
                //Margin = newMargin;
                UpdateChart();
            }
        }
    }
}
