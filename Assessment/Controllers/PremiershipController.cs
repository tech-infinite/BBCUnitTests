using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment.Controllers
{
    public class PremiershipController : Controller
    {

    

        [NonAction]
        public List<PremierLeagueFixture> GetGameTobePlayedByTottenham()
        {
            return new List<PremierLeagueFixture>{
            
             new PremierLeagueFixture{
               ID = 1,
               HomeTeam = "Brentford",
               AwayTeam = "Tottenham Hotspur",
               GameDate = DateTime.Parse("2022-12-26"),
               Stadium = "Brentford"
              },
             new PremierLeagueFixture{
               ID = 2,
               HomeTeam = "Tottenham Hotspur",
               AwayTeam = "Aston Villa",
               GameDate = DateTime.Parse("2023-01-01"),
               Stadium = "Tottenham Hotspur"
              },
             new PremierLeagueFixture{
               ID = 3,
               HomeTeam = "Crystal Palace ",
               AwayTeam = "Tottenham Hotspur",
               GameDate = DateTime.Parse("2023-04-01"),
               Stadium = "Crystal Palace"
              },
             new PremierLeagueFixture{
               ID = 4,
               HomeTeam = "Tottenham Hotspur",
               AwayTeam = "Arsenal",
               GameDate = DateTime.Parse("2023-01-14"),
               Stadium = "Tottenham Hotspur Stadium"
              },
             new PremierLeagueFixture{
               ID = 5,
               HomeTeam = "Fulham",
               AwayTeam = "Tottenham Hotspur",
               GameDate = DateTime.Parse("2022-01-21"),
               Stadium = "Tottenham Hotspur Stadium"
            },

         };
        }

        public List<LeagueTableStand> GetLeagueTableStandList()
        {
            return new List<LeagueTableStand>{
            new LeagueTableStand{
               Id = 1,
               TeamName = "Arsenal",
               Postion = 1,
               MatchWon = 11,
               NumberOfDraws = 1,
               MatchPlayed = 13,
               MatchLost = 1
            },
            new LeagueTableStand{
               Id = 2,
               TeamName = "Man City",
               Postion =2,
               MatchWon = 10,
               NumberOfDraws = 4,
               MatchPlayed = 13,
               MatchLost = 1
            },
            new LeagueTableStand{
               Id = 3,
               TeamName = "Newcastle",
               Postion =3,
               MatchWon = 7,
               NumberOfDraws = 6,
               MatchPlayed = 14,
               MatchLost = 1
            },
            new LeagueTableStand{
               Id = 4,
               TeamName = "Tottenham",
               Postion = 4,
               MatchWon = 8,
               NumberOfDraws = 2,
               MatchPlayed = 14,
               MatchLost = 4
            },

            
                new LeagueTableStand{
               Id = 5,
               TeamName = "Man United",
               Postion =5,
               MatchWon = 8,
               NumberOfDraws = 2,
               MatchPlayed = 13,
               MatchLost = 4
            },

            new LeagueTableStand{
               Id = 6,
               TeamName = "Brighton",
               Postion = 10,
               MatchWon = 6,
               NumberOfDraws = 3,
               MatchPlayed = 13,
               MatchLost = 4
            },

            new LeagueTableStand{
               Id = 7,
               TeamName = "Chelsea",
               Postion = 8,
               MatchWon = 6,
               NumberOfDraws = 3,
               MatchPlayed = 13,
               MatchLost = 4
            },

            new LeagueTableStand{
               Id = 8,
               TeamName = "Liverpool",
               Postion = 6,
               MatchWon = 5,
               NumberOfDraws = 4,
               MatchPlayed = 13,
               MatchLost = 4
            },

            new LeagueTableStand{
               Id = 9,
               TeamName = "Fulham",
               Postion = 9,
               MatchWon = 5,
               NumberOfDraws = 4,
               MatchPlayed = 14,
               MatchLost = 5
            },

            new LeagueTableStand{
               Id = 10,
               TeamName = "Crystal Palace",
               Postion =11,
               MatchWon = 5,
               NumberOfDraws = 4,
               MatchPlayed = 13,
               MatchLost = 4
            },

            new LeagueTableStand{
               Id = 11,
               TeamName = "Brentford",
               Postion =11,
               MatchWon = 3,
               NumberOfDraws = 7,
               MatchPlayed = 14,
               MatchLost = 4
            },
            
            new LeagueTableStand{
               Id = 12,
               TeamName = "Leeds",
               Postion =14,
               MatchWon = 4,
               NumberOfDraws = 3,
               MatchPlayed = 13,
               MatchLost = 6
            },
new LeagueTableStand{
               Id = 13,
               TeamName = "Aston Villa",
               Postion =15,
               MatchWon = 4,
               NumberOfDraws = 3,
               MatchPlayed = 14,
               MatchLost = 7
            },
new LeagueTableStand{
               Id = 14,
               TeamName = "Leicester",
               Postion =12,
               MatchWon = 4,
               NumberOfDraws = 2,
               MatchPlayed = 14,
               MatchLost = 8
            },
    new LeagueTableStand{
               Id = 15,
               TeamName = "West Ham",
               Postion =16,
               MatchWon = 4,
               NumberOfDraws = 2,
               MatchPlayed = 14,
               MatchLost = 8
            },

    new LeagueTableStand{
               Id = 16,
               TeamName = "Everton",
               Postion =17,
               MatchWon = 3,
               NumberOfDraws = 5,
               MatchPlayed = 14,
               MatchLost = 6
            },
    new LeagueTableStand{
               Id = 17,
               TeamName = "Bournemouth",
               Postion =13,
               MatchWon = 3,
               NumberOfDraws = 4,
               MatchPlayed = 14,
               MatchLost = 7
            },
    new LeagueTableStand{
               Id = 18,
               TeamName = "Southampton",
               Postion =19,
               MatchWon = 3,
               NumberOfDraws = 3,
               MatchPlayed = 14,
               MatchLost = 8
            },
    new LeagueTableStand{
               Id = 19,
               TeamName = "Wolves",
               Postion =20,
               MatchWon = 2,
               NumberOfDraws = 4,
               MatchPlayed = 14,
               MatchLost = 8
            },
    new LeagueTableStand{
               Id = 20,
               TeamName = "Nottingham",
               Postion =18,
               MatchWon = 2,
               NumberOfDraws = 4,
               MatchPlayed = 14,
               MatchLost = 8
            },


         };
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PremierLeague()
        {
            var PremierLeagues = from e in GetGameTobePlayedByTottenham()
                                 orderby e.ID
                                 select e;
            return View(PremierLeagues);
        }

        public ActionResult GetPremierLeagueByID(int Id)
        {
            var PremierLeagues = from e in GetGameTobePlayedByTottenham().Where(s => s.ID == Id)
                                 group e by new { e.ID, e.AwayTeam, e.HomeTeam, e.GameDate, e.Stadium } into g
                                 select new
                                 {
                                     ID = g.Key.ID,
                                     AwayTeam = g.Key.AwayTeam,
                                     HomeTeam = g.Key.HomeTeam,
                                     GameDate = g.Key.GameDate,
                                     Stadium = g.Key.Stadium
                                 };
            TempData["name"] = PremierLeagues.Select(x => x.AwayTeam);
            return View(PremierLeagues);
        }


        public ActionResult GetBottom5EasyGames(int Id)
        {           
          var   GetStandOnTableList = from gs in GetLeagueTableStandList()
                                      orderby gs.Postion
                                      select gs;
            var PremierLeagues = from e in GetGameTobePlayedByTottenham().Where(s => s.ID == Id)
                                 group e by new { e.ID, e.AwayTeam, e.HomeTeam, e.GameDate, e.Stadium } into g
                                 select new
                                 {
                                     ID = g.Key.ID,
                                     AwayTeam = g.Key.AwayTeam,
                                     HomeTeam = g.Key.HomeTeam,
                                     GameDate = g.Key.GameDate,
                                     Stadium = g.Key.Stadium
                                 };
            var myEasyGames = new List<LeagueTableStand>();
            foreach (var item in PremierLeagues)
            {
                myEasyGames = GetStandOnTableList.Where(x => x.MatchLost >= 8 && x.TeamName != "Tottenham Hotspur").OrderBy(o=>o.Postion).Take(5).ToList();
            }

            return View(myEasyGames);
        }
        public ActionResult GetNotBottom5EasyGames(int Id)
        {
            var GetStandOnTableList = from gs in GetLeagueTableStandList()
                                      orderby gs.Postion
                                      select gs;
            var PremierLeagues = from e in GetGameTobePlayedByTottenham().Where(s => s.ID == Id)
                                 group e by new { e.ID, e.AwayTeam, e.HomeTeam, e.GameDate, e.Stadium } into g
                                 select new
                                 {
                                     ID = g.Key.ID,
                                     AwayTeam = g.Key.AwayTeam,
                                     HomeTeam = g.Key.HomeTeam,
                                     GameDate = g.Key.GameDate,
                                     Stadium = g.Key.Stadium
                                 };
            var notEasyGames = new List<LeagueTableStand>();
            foreach (var item in PremierLeagues)
            {
                notEasyGames = GetStandOnTableList.Where(x => x.MatchLost <=6  && x.TeamName != "Tottenham Hotspur").OrderByDescending(o => o.Postion).Take(5).ToList();
               
            }

            return View(notEasyGames);
        }
    }
}