using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.Charts
{
    public static class TransitsChart
    {
        public static LiveChartsCore.Measure.Margin Margin { get; set; }

        public static List<ISeries> Series { get; set; }

        static TransitsChart()
        {
            Margin = new LiveChartsCore.Measure.Margin(40, 20, 600, 40);

            Series = new List<ISeries>() {
            new LineSeries<double>
            {
                Values = new List<double>(),
                Fill = null
            }};
            AddValues(new double[]{ 2, 1, 3, 5, 3, 4, 6, 7, 10, 2, 4, 2, 1});
        }

        public static void AddValue(double value, int series = 0)
        {
            ((List<double>)Series[series].Values).Add(value);
        }
        public static void AddValues(IEnumerable<double> values, int series = 0)
        {
            ((List<double>)Series[series].Values).AddRange(values);
        }

    }
}
