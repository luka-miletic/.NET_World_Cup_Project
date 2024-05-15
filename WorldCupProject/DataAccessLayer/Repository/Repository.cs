using DataAccessLayer.Models;
using DataAccessLayer.Settings;
using Newtonsoft.Json;
using RestSharp;


namespace DataAccessLayer.Repository
{
    class Repository : IRepository
    {
        private const string URL = $"http://worldcup-vua.nullbit.hr";
        private const string PATH = $"../../../../Resources/worldcup.sfg.io";

        private List<Team> teamList;
        private List<Match> matchList;
        private List<Result> resultList;
        private List<GroupResult> groupResultList;

        public List<Team> GetAllTeams()
        {
            return this.teamList;
        }

        public List<Match> GetAllMatches() 
        {
            return this.matchList;
        }
        
        public List<Result> GetAllResults()
        {
            return this.resultList;
        }

        public List<GroupResult> GetAllGroupResults()
        {
            return this.groupResultList;
        }

        public List<Match> GetMatchesForCountry(string countryCode)
        {
            List<Match> matches = new List<Match>();

            foreach(Match match in this.matchList)
            {
                if(match.AwayTeam.FifaCode.Equals(countryCode) || match.HomeTeam.FifaCode.Equals(countryCode))
                {
                    matches.Add(match);
                }
            }

            return matches;
        }

        public List<Match> GetRankedMatchesForCountry(string countryCode)
        {
            return GetMatchesForCountry(countryCode).OrderBy(x => x.Attendance).Reverse().ToList();
        }

        public Result GetResultForCountry(string countryCode)
        {

            foreach(Result result in this.resultList)
            {
                if(result.FifaCode == countryCode) 
                {
                    return result;
                }
            }

            throw new Exception("Result not found");
        }

        public HashSet<Player> GetAllPlayers()
        {
            HashSet<Player> playerSet = new();

            foreach (Match m in matchList)
            {

                m.HomeTeamStatistics.StartingEleven.ForEach(x => playerSet.Add(x));
                m.HomeTeamStatistics.Substitutes.ForEach(x => playerSet.Add(x));

                m.AwayTeamStatistics.StartingEleven.ForEach(x => playerSet.Add(x));
                m.AwayTeamStatistics.Substitutes.ForEach(x => playerSet.Add(x));

            }

            return playerSet;

        }

        public HashSet<Player> GetPlayersForCountry(string countryCode)
        {
            HashSet<Player> playerSet = new();

            foreach (Match m in matchList)
            {
                if(m.HomeTeam.FifaCode.Equals(countryCode))
                {
                    foreach(Player p in m.HomeTeamStatistics.StartingEleven)
                    {
                        playerSet.Add(p);
                    }
                    foreach (Player p in m.HomeTeamStatistics.Substitutes)
                    {
                        playerSet.Add(p);
                    }
                }

                else if(m.AwayTeam.FifaCode.Equals(countryCode))
                {
                    foreach (Player p in m.AwayTeamStatistics.StartingEleven)
                    {
                        playerSet.Add(p);
                    }
                    foreach (Player p in m.AwayTeamStatistics.Substitutes)
                    {
                        playerSet.Add(p);
                    }
                }
            }

            return playerSet;
        }

        public HashSet<Player> GetRankedPlayersForCountry(string countryCode)
        {
            HashSet<Player> tempPlayerList = GetPlayersForCountry(countryCode);
            List<Match> tempMatchList = GetMatchesForCountry(countryCode);

            foreach(Player p in tempPlayerList)
            {
                p.Goals = 0;
                p.YellowCards = 0;
                p.noAppearances = 0;

                foreach(Match m in tempMatchList)
                {
                    if(m.HomeTeam.FifaCode == countryCode)
                    {
                        if (m.HomeTeamStatistics.StartingEleven.Contains(p) || m.HomeTeamStatistics.Substitutes.Contains(p))
                        {
                            p.noAppearances++;
                        }

                        foreach (TeamEvent e in m.HomeTeamEvents)
                        {
                            if ((e.TypeOfEvent == TypeOfEvent.Goal || e.TypeOfEvent == TypeOfEvent.GoalPenalty) && e.Player == p.Name)
                            {
                                p.Goals++;
                            }

                            if (e.TypeOfEvent == TypeOfEvent.YellowCard && e.Player == p.Name)
                            {
                                p.YellowCards++;
                            }
                        }
                    }
                    else
                    {
                        if (m.AwayTeamStatistics.StartingEleven.Contains(p) || m.AwayTeamStatistics.Substitutes.Contains(p))
                        {
                            p.noAppearances++;
                        }

                        foreach (TeamEvent e in m.AwayTeamEvents)
                        {
                            if ((e.TypeOfEvent == TypeOfEvent.Goal || e.TypeOfEvent == TypeOfEvent.GoalPenalty) && e.Player == p.Name)
                            {
                                p.Goals++;
                            }

                            if (e.TypeOfEvent == TypeOfEvent.YellowCard && e.Player == p.Name)
                            {
                                p.YellowCards++;
                            }
                        }
                    }
                }
            }

            List<Player> playerListSorted = tempPlayerList.ToList();
            return playerListSorted.OrderBy(p => p.Goals).ThenBy(p => p.YellowCards).Reverse().ToHashSet<Player>();
        }




        public async Task LoadData(DataAccessMode dataAccessMode, Gender gender)
        {
            if (dataAccessMode == DataAccessMode.API)
            {
                string fullpath = URL + "/" + gender.ToString().ToLower();

                var teamsJson = await GetDataFromAPI(fullpath + "/teams");
                this.teamList = JsonConvert.DeserializeObject<List<Team>>(teamsJson);

                var matchesJson = await GetDataFromAPI(fullpath + "/matches");
                this.matchList = JsonConvert.DeserializeObject<List<Match>>(matchesJson);

                var resultsJson = await GetDataFromAPI(fullpath + "/teams/results");
                this.resultList = JsonConvert.DeserializeObject<List<Result>>(resultsJson);

                var groupResultsJson = await GetDataFromAPI(fullpath + "/teams/group_results");
                this.groupResultList = JsonConvert.DeserializeObject<List<GroupResult>>(resultsJson);
            }
            else if (dataAccessMode == DataAccessMode.FILE)
            {
                string fullPath = PATH + "/" + gender.ToString().ToLower();

                var teamsJson = await System.IO.File.ReadAllTextAsync(fullPath + "/teams.json");
                this.teamList = JsonConvert.DeserializeObject<List<Team>>(teamsJson);

                var matchesJson = await System.IO.File.ReadAllTextAsync(fullPath + "/matches.json");
                this.matchList = JsonConvert.DeserializeObject<List<Match>>(matchesJson);

                var resultsJson = await System.IO.File.ReadAllTextAsync(fullPath + "/results.json");
                this.resultList = JsonConvert.DeserializeObject<List<Result>>(resultsJson);

                var groupResultsJson = await System.IO.File.ReadAllTextAsync(fullPath + "/group_results.json");
                this.groupResultList = JsonConvert.DeserializeObject<List<GroupResult>>(groupResultsJson);
            }
            else
            {
                throw new Exception("Invalid data access type");
            }
        }

        private async Task<String> GetDataFromAPI(string APIUrl)
        {
            var apiClient = new RestClient(APIUrl);
            return (await apiClient.ExecuteAsync<Object>(new RestRequest())).Content;
        }

        public List<Team> GetTeamsVsCountry(string CountryCode)
        {
            List<Match> matches = GetMatchesForCountry(CountryCode);

            List<Team> teams = new();

            foreach (Match match in matches)
            {
                if(match.AwayTeam.FifaCode != CountryCode)
                {
                    teams.Add(match.AwayTeam);
                }

                if(match.HomeTeam.FifaCode != CountryCode)
                {
                    teams.Add(match.HomeTeam);
                }
            }

            return teams;

        }

        public Match GetMatchBetweenTeams(string countryCode1, string countryCode2)
        {
            List<Match> matches = GetMatchesForCountry(countryCode1);

            foreach(Match m in matches)
            {
                if(m.AwayTeam.FifaCode == countryCode2 || m.HomeTeam.FifaCode == countryCode2)
                {
                    return m;
                }
            }

            return null;
        }
    }
}
