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
    public static class TeamRepository
    {
        public static List<Team> teamList = new List<Team>();

        public async static Task initTeamListFromFile(string GenderSetting)
        {
            string FileUrl = $"../../../../Resources/worldcup.sfg.io/{GenderSetting}/teams.json";

            var json = await File.ReadAllTextAsync(FileUrl);

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);

            teamList = teams;
        }

        public async static Task initTeamListFromAPI(string GenderSetting)
        {
            string APIUrl = $"https://worldcup-vua.nullbit.hr/{GenderSetting}/teams";

            RestResponse<Team> response = await GetData(APIUrl);

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(response.Content);

            teamList = teams;
        }

        private static Task<RestResponse<Team>> GetData(string APIUrl)
        {
            var apiClient = new RestClient(APIUrl);
            return apiClient.ExecuteAsync<Team>(new RestRequest());
        }
    }
}
