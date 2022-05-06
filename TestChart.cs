using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere
{
    public class TestChart
    {
        public LiveChartsCore.Measure.Margin Margin { get; set; } = new LiveChartsCore.Measure.Margin(40, 20, 500, 40);

        public ISeries[] Series { get; set; }
            = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
            };

        //Series[0].Values = ((double[])Series[0].Values).Append(4);

    }
}
