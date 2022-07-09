using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.DataModel
{
    public class SourceSummary
    {
        /// <summary>
        /// The Gaia Source ID; the primary key.
        /// </summary>
        public virtual ulong SourceID { get; set; }
        /// <summary>
        /// Right Ascension (degrees).
        /// </summary>
        public virtual double RA { get; set; }
        /// <summary>
        /// Declination (degrees).
        /// </summary>
        public virtual double Dec { get; set; }
        /// <summary>
        /// Distance (parsecs).
        /// </summary>
        public virtual float Dist { get; set; }
        /// <summary>
        /// Stellar class / spectral type (C, M, K, G, F, A, B ,O).
        /// </summary>
        public virtual string Class { get; set; }
        /// <summary>
        /// Effective temperature (kelvin).
        /// </summary>
        public virtual float Teff { get; set; }
        /// <summary>
        /// Age (billions of years).
        /// </summary>
        public virtual float Age { get; set; }  
        /// <summary>
        /// Magnitude (Vega zero-point).
        /// </summary>
        public virtual float Mag { get; set; }

    }

    public class SourceDetails
    {
        /// <summary>
        /// Radius (sol radius)
        /// </summary>
        public virtual float Radius { get; set; }
        /// <summary>
        /// Surface gravity (log10[cm/s^2])
        /// </summary>
        public virtual float SurfaceG { get; set; }
        /// <summary>
        /// Luminosity (sol luminosity)
        /// </summary>
        public virtual string Lum { get; set; }

        //TODO: Mass, Flux, metallicity, is late giant, etc.
    }

    public class SourcePhotometry
    {

    }

    public class SourceTransits
    {

    }
}
