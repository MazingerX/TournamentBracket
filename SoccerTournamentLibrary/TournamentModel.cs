using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerTournamentLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public string EntryFee { get; set; }
        public string EnteredTeams { get; set; } = new List<TeamModel>();
        public string Prizes { get; set; } = new List<PrizeModel>();
        public string Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
