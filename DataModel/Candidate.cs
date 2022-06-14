using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.DataModel
{

    public class CandidateSummary
    {
        /// <summary>
        /// The Gaia Source ID; the primary key.
        /// </summary>
        public ulong SourceID { get; set; }
        /// <summary>
        /// An abbreviated representation of the SourceID; the first and last 3 digits.
        /// </summary>
        public string ShortSource
        {
            get
            {
                string tmpStr = SourceID.ToString();
                return tmpStr[..3] + ".." + tmpStr[^3..];
            }
        }
        /// <summary>
        /// Right Ascension (degrees).
        /// </summary>
        public double RA { get; set; }
        /// <summary>
        /// Declination (degrees).
        /// </summary>
        public double Dec { get; set; }
        /// <summary>
        /// Distance (parsecs).
        /// </summary>
        public float Dist { get; set; }
        /// <summary>
        /// Stellar class / spectral type (C, M, K, G, F, A, B ,O).
        /// </summary>
        public string Class { get; set; }
        public Color ClassColor
        {
            get
            {
                return Class switch
                {
                    "C" => Colors.Red,
                    "M" => Colors.OrangeRed,
                    "K" => Colors.Orange,
                    "G" => Colors.PapayaWhip,
                    "F" => Colors.FloralWhite,
                    "A" => Colors.LightSkyBlue,
                    "B" => Colors.CornflowerBlue,
                    "O" => Colors.DodgerBlue,
                    _ => Colors.Black,
                };
            }
        }
        /// <summary>
        /// Effective temperature (kelvin).
        /// </summary>
        public float Teff { get; set; }
        /// <summary>
        /// Age (billions of years).
        /// </summary>
        public float Age { get; set; }
        /// <summary>
        /// Magnitude (Vega zero-point).
        /// </summary>
        public float Mag { get; set; }
        
    }

    public class CandidateDetails
    {
        /// <summary>
        /// Radius (sol radius)
        /// </summary>
        public float Radius { get; set; }
        /// <summary>
        /// Surface gravity (log10[cm/s^2])
        /// </summary>
        public float SurfaceG { get; set; }
        /// <summary>
        /// Luminosity (sol luminosity)
        /// </summary>
        public string Lum { get; set; }

        //TODO: Mass, Flux, metallicity, is late giant, etc.
    }

    public class CandidatePhotometry
    {
        
    }

    public class CandidateTransits
    {

    }

    public class Candidate
    {
        public CandidateSummary Summary { get; set; }
        public CandidateDetails Details { get; set; }
        public CandidatePhotometry Photometry { get; set; }
        public CandidateTransits Transits { get; set; }

        public static List<Candidate> All { get; private set; }
        private static Candidate _selectedCandidate;
        /// <summary>
        /// Used to synchronize selected candidate between Pages (instances of ResultsListView).
        /// </summary>
        public static Candidate SelectedCandidate
        {
            get { return _selectedCandidate; }
            set
            {
                var prev = _selectedCandidate;
                _selectedCandidate = value;
                if (prev != value) CandidateSelected?.Invoke(value, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Raised when the SelectedCandidate (which is also the selected Candidate in the common ResultsListView) changes.
        /// Note that the typical sender object is instead used as the candidate itself to avoid the need to create an EventArgs class etc..
        /// </summary>
        public static event EventHandler CandidateSelected;


        static Candidate()
        {
            All = new List<Candidate>();

            //TODO: Temporary
            All.Add(new Candidate
            {
                Summary = new CandidateSummary {
                    SourceID = 18446744073709551615,
                    RA = 25.43273943,
                    Dec = 41.0923418283,
                    Dist = 1.254f,
                    Class = "K",
                    Teff = 4035.21f,
                    Age = 3.21f,
                    Mag = 7.3f
                },
                Details = new CandidateDetails { },
                Photometry = new CandidatePhotometry { },
                Transits = new CandidateTransits { }
            });
            All.Add(new Candidate
            {
                Summary = new CandidateSummary {
                    SourceID = 4356744073709550432,
                    RA = 1.90837423,
                    Dec = 80.2304193,
                    Dist = 7.02823f,
                    Class = "F",
                    Teff = 6242.17f,
                    Age = 1.17f,
                    Mag = 1.7f
                },
                Details = new CandidateDetails { },
                Photometry = new CandidatePhotometry { },
                Transits = new CandidateTransits { }
            });
            All.Add(new Candidate
            {
                Summary = new CandidateSummary {
                    SourceID = 10126744073709550923,
                    RA = 72.038471834743,
                    Dec = 9.83401834,
                    Dist = 22.31634f,
                    Class = "B",
                    Teff = 29028.94f,
                    Age = 5.22f,
                    Mag = -6.0f
                },
                Details = new CandidateDetails { },
                Photometry = new CandidatePhotometry { },
                Transits = new CandidateTransits { }
            });

            SelectedCandidate = All[0];
        }

        public static void AddCandidate(Candidate candidate)
        {
            All.Add(candidate);
        }
    }


}
