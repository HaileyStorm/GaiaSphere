using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.Charts
{
    public sealed class TransitsChart : Chart
    {
        // "Static" constructor used to instantiate singleton
        private TransitsChart() : base()
        {
            AddValues(new double[] { 2, 1, 3, 5, 3, 4, 6, 7, 10, 2, 4, 2, 1 });
        }

        // Create singleton
        private static readonly Lazy<TransitsChart> lazy = new Lazy<TransitsChart>(() => new TransitsChart());
        public static TransitsChart Instance => lazy.Value;

        
    }
}
