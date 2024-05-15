using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Models;

using Newtonsoft.Json;
using RestSharp;

namespace DataAccessLayer.Repositories
{
    public static class MatchRepository
    {
        public static List<Match> matchList = new List<Match>();
        public static HashSet<Player> playerList = new HashSet<Player>();

        private static Task<RestResponse<Match>> GetData(string APIUrl)
        {
            var apiClient = new RestClient(APIUrl);
            return apiClient.ExecuteAsync<Match>(new RestRequest());
        }

        public async static Task initMatchListFromFile(string GenderSetting, Team team)
        {
            string FileUrl = $"../../../../Resources/worldcup.sfg.io/{GenderSetting}/matches.json";

            var json = await File.ReadAllTextAsync(FileUrl);

            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(json);

            foreach(Match match in matches)
            {
                if (match.HomeTeam.FifaCode == team.FifaCode || match.AwayTeam.FifaCode == team.FifaCode)
                {
                    matches.Remove(match);
                }
            }

            matchList = matches;
            
        }

        public async static Task initMatchListFromFile(string GenderSetting)
        {
            string FileUrl = $"../../../../Resources/worldcup.sfg.io/{GenderSetting}/matches.json";

            var json = await File.ReadAllTextAsync(FileUrl);

            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(json);

            matchList = matches;
        }

        public async static Task initMatchListFromAPI(string GenderSetting)
        {
            string APIUrl = $"https://worldcup-vua.nullbit.hr/{GenderSetting}/matches";

            RestResponse<Match> response = await GetData(APIUrl);

            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(response.Content);

            matchList = matches;
        }

        public async static Task initMatchListFromAPI(string GenderSetting, Team team)
        {
            string APIUrl = $"https://worldcup-vua.nullbit.hr/{GenderSetting}/matches/country?fifa_code={team.FifaCode}";

            RestResponse<Match> response = await GetData(APIUrl);

            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(response.Content);

            matchList = matches;
        }

        public static void initPlayerList(Team team)
        {

         List<Player> tempPlayerList = new List<Player>();

            foreach(Match match in matchList)
            {
                if (match.HomeTeam.FifaCode == team.FifaCode)
                {
                    tempPlayerList.AddRange(match.HomeTeamStatistics.StartingEleven);
                    tempPlayerList.AddRange(match.HomeTeamStatistics.Substitutes);
                }
                else if (match.AwayTeam.FifaCode == team.FifaCode)
                {
                    tempPlayerList.AddRange(match.AwayTeamStatistics.StartingEleven);
                    tempPlayerList.AddRange(match.AwayTeamStatistics.Substitutes);
                }
            }

            tempPlayerList.Sort();

            playerList = tempPlayerList.ToHashSet();

        }
    }
}
