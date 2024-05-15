using DataAccessLayer.Models;
using DataAccessLayer.Settings;

namespace DataAccessLayer.Repository
{
    public interface IRepository
    {
        public Task LoadData(DataAccessMode dataAccessMode, Gender gender);

        public List<Team> GetAllTeams();
        public List<Team> GetTeamsVsCountry(string CountryCode);

        public List<Match> GetAllMatches();
        public List<Match> GetMatchesForCountry(string countryCode);
        public List<Match> GetRankedMatchesForCountry(string countryCode);
        public Match GetMatchBetweenTeams(string countryCode1, string countryCode2);

        public HashSet<Player> GetAllPlayers();
        public HashSet<Player> GetPlayersForCountry(string countryCode);
        public HashSet<Player> GetRankedPlayersForCountry(string countryCode);


        public List<Result> GetAllResults();
        public Result GetResultForCountry(string countryCode);

        public List<GroupResult> GetAllGroupResults();
    }
}
