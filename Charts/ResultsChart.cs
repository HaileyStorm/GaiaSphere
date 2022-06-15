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
    /// Manages the SearchPage results chart, which is a scatter plot of candidates with x-axis=RA*cos(DEC) [0-360] and y-axis=DEC [-90 - 90]
    /// Would like color to represent spectral type and size to represent distance ... may need to bucket size and have separate series for
    /// each spectral type, depending on LiveCharts functionality.
    /// </summary>
    public sealed class ResultsChart : Chart
    {
        // "Static" constructor used to instantiate singleton
        private ResultsChart() : base()
        {
            AddValues(new double[] { 2, 1, 3, 5, 3, 4, 6, 7, 10, 2, 4, 2, 1 });
            AddSeries(new double[] { 7, 4, 6, 2, 9 });
        }

        // Create singleton
        private static readonly Lazy<ResultsChart> lazy = new Lazy<ResultsChart>(() => new ResultsChart());
        public static ResultsChart Instance => lazy.Value;
    }
}
