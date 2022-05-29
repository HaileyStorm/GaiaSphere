using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere
{
    public static class ResultsChart
    {
        public static LiveChartsCore.Measure.Margin Margin { get; set; }

        public static ISeries[] Series { get; set; }

        static ResultsChart()
        {
            Margin = new LiveChartsCore.Measure.Margin(40, 20, 600, 40);

            Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6, 7, 10, 2, 4, 2, 1 },
                    Fill = null
                }
            };
        }
    }
}
