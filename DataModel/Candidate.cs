using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSphere.DataModel
{


    public class Candidate
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }

        public static List<Candidate> All { get; private set; }
        /// <summary>
        /// Used to synchronize selected candidate between Pages (instances of ResultsListView).
        /// </summary>
        public static Candidate SelectedCandidate { get; set; }


        static Candidate()
        {
            All = new List<Candidate>();

            //TODO: Temporary
            All.Add(new Candidate
            {
                Name = "Test1",
                Location = "Location",
                Details = "Details"
            });
            All.Add(new Candidate
            {
                Name = "Test2",
                Location = "Location",
                Details = "Details"
            });
            All.Add(new Candidate
            {
                Name = "Test3",
                Location = "Location",
                Details = "Details"
            });

            SelectedCandidate = All[0];
        }

        public static void AddCandidate(Candidate candidate)
        {
            All.Add(candidate);
        }
    }


}
