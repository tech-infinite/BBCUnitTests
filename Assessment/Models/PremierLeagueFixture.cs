using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment.Models
{
    public class PremierLeagueFixture
    {
        public int ID { get; set; }
        public string Stadium { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime GameDate { get; set; }

    }
}