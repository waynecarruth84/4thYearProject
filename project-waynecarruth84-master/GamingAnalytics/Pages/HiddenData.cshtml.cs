using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace GamingAnalytics.Pages
{
    public class HiddenDataModel : PageModel
    {
        [BindProperty]
        public string summonerName { get; set; }
        public class Root
        {
            [JsonPropertyName("id")]
            public static string Id { get; set; }

            [JsonPropertyName("accountId")]
            public static string AccountId { get; set; }

            [JsonPropertyName("puuid")]
            public static string Puuid { get; set; }

            [JsonPropertyName("name")]
            public static string Name { get; set; }

            [JsonPropertyName("profileIconId")]
            public static int ProfileIconId { get; set; }

            [JsonPropertyName("revisionDate")]
            public static long RevisionDate { get; set; }

            [JsonPropertyName("summonerLevel")]
            public static int SummonerLevel { get; set; }
        }

        public String apiCall()
        {
            String API_KEY = "RGAPI-bb6d7a3e-eb72-4306-a5f1-010be3f38d48";

            String SummonerUrl = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=" + API_KEY;

            return SummonerUrl;

        }

        public String UserIdDetails()
        {

            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userid = dynamicobject.id.ToString();

            return userid;
        }
        public String UserNameDetails()
        {
            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userName = dynamicobject.name.ToString();

            return userName;
        }

        public String UserLvlDetails()
        {
            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLvl = dynamicobject.summonerLevel.ToString();

            return userLvl;
        }

        public String UserPUIdDetails()
        {

            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userAccountId = dynamicobject.puuid;

            return userAccountId;
        }

        public String UserAccountIdDetails()
        {

            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userAccountId = dynamicobject.accountId.ToString();

            return userAccountId;
        }

        public DateTime UserRevisionDetails()
        {

            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            long userRevisionDate = dynamicobject.revisionDate;

            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(userRevisionDate).ToLocalTime();
            //var userRevisionDateConverted = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(userRevisionDate).ToShortDateString();

            return dtDateTime;
        }

        public String UserProfileIconIdDetails()
        {

            string json = new WebClient().DownloadString(apiCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userProfileIconId = dynamicobject.profileIconId.ToString();

            return userProfileIconId;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            HttpContext.Session.SetString("summonerName", summonerName);

        }
    }
}