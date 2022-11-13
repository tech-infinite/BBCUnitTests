using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment.Models
{
    public class LeagueTableStand
    {
        public int Id { get; set; }        
        public string TeamName { get; set; }
        public int Postion { get; set; }
        public int MatchPlayed { get; set; }
        public int MatchWon { get; set; }
        public int NumberOfDraws { get; set; }
        public int MatchLost { get; set; }
    }
}