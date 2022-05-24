using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

namespace GamingAnalytics.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty]
        public string summonerName { get; set; }
        public class Ban
        {
            [JsonProperty("championId")]
            public int ChampionId { get; set; }

            [JsonProperty("pickTurn")]
            public int PickTurn { get; set; }
        }

        public class Team
        {
            [JsonProperty("teamId")]
            public int TeamId { get; set; }

            [JsonProperty("win")]
            public string Win { get; set; }

            [JsonProperty("firstBlood")]
            public bool FirstBlood { get; set; }

            [JsonProperty("firstTower")]
            public bool FirstTower { get; set; }

            [JsonProperty("firstInhibitor")]
            public bool FirstInhibitor { get; set; }

            [JsonProperty("firstBaron")]
            public bool FirstBaron { get; set; }

            [JsonProperty("firstDragon")]
            public bool FirstDragon { get; set; }

            [JsonProperty("firstRiftHerald")]
            public bool FirstRiftHerald { get; set; }

            [JsonProperty("towerKills")]
            public int TowerKills { get; set; }

            [JsonProperty("inhibitorKills")]
            public int InhibitorKills { get; set; }

            [JsonProperty("baronKills")]
            public int BaronKills { get; set; }

            [JsonProperty("dragonKills")]
            public int DragonKills { get; set; }

            [JsonProperty("vilemawKills")]
            public int VilemawKills { get; set; }

            [JsonProperty("riftHeraldKills")]
            public int RiftHeraldKills { get; set; }

            [JsonProperty("dominionVictoryScore")]
            public int DominionVictoryScore { get; set; }

            [JsonProperty("bans")]
            public List<Ban> Bans { get; set; }
        }

        public class Stats
        {
            [JsonProperty("participantId")]
            public int ParticipantId { get; set; }

            [JsonProperty("win")]
            public bool Win { get; set; }

            [JsonProperty("item0")]
            public int Item0 { get; set; }

            [JsonProperty("item1")]
            public int Item1 { get; set; }

            [JsonProperty("item2")]
            public int Item2 { get; set; }

            [JsonProperty("item3")]
            public int Item3 { get; set; }

            [JsonProperty("item4")]
            public int Item4 { get; set; }

            [JsonProperty("item5")]
            public int Item5 { get; set; }

            [JsonProperty("item6")]
            public int Item6 { get; set; }

            [JsonProperty("kills")]
            public int Kills { get; set; }

            [JsonProperty("deaths")]
            public int Deaths { get; set; }

            [JsonProperty("assists")]
            public int Assists { get; set; }

            [JsonProperty("largestKillingSpree")]
            public int LargestKillingSpree { get; set; }

            [JsonProperty("largestMultiKill")]
            public int LargestMultiKill { get; set; }

            [JsonProperty("killingSprees")]
            public int KillingSprees { get; set; }

            [JsonProperty("longestTimeSpentLiving")]
            public int LongestTimeSpentLiving { get; set; }

            [JsonProperty("doubleKills")]
            public int DoubleKills { get; set; }

            [JsonProperty("tripleKills")]
            public int TripleKills { get; set; }

            [JsonProperty("quadraKills")]
            public int QuadraKills { get; set; }

            [JsonProperty("pentaKills")]
            public int PentaKills { get; set; }

            [JsonProperty("unrealKills")]
            public int UnrealKills { get; set; }

            [JsonProperty("totalDamageDealt")]
            public int TotalDamageDealt { get; set; }

            [JsonProperty("magicDamageDealt")]
            public int MagicDamageDealt { get; set; }

            [JsonProperty("physicalDamageDealt")]
            public int PhysicalDamageDealt { get; set; }

            [JsonProperty("trueDamageDealt")]
            public int TrueDamageDealt { get; set; }

            [JsonProperty("largestCriticalStrike")]
            public int LargestCriticalStrike { get; set; }

            [JsonProperty("totalDamageDealtToChampions")]
            public int TotalDamageDealtToChampions { get; set; }

            [JsonProperty("magicDamageDealtToChampions")]
            public int MagicDamageDealtToChampions { get; set; }

            [JsonProperty("physicalDamageDealtToChampions")]
            public int PhysicalDamageDealtToChampions { get; set; }

            [JsonProperty("trueDamageDealtToChampions")]
            public int TrueDamageDealtToChampions { get; set; }

            [JsonProperty("totalHeal")]
            public int TotalHeal { get; set; }

            [JsonProperty("totalUnitsHealed")]
            public int TotalUnitsHealed { get; set; }

            [JsonProperty("damageSelfMitigated")]
            public int DamageSelfMitigated { get; set; }

            [JsonProperty("damageDealtToObjectives")]
            public int DamageDealtToObjectives { get; set; }

            [JsonProperty("damageDealtToTurrets")]
            public int DamageDealtToTurrets { get; set; }

            [JsonProperty("visionScore")]
            public int VisionScore { get; set; }

            [JsonProperty("timeCCingOthers")]
            public int TimeCCingOthers { get; set; }

            [JsonProperty("totalDamageTaken")]
            public int TotalDamageTaken { get; set; }

            [JsonProperty("magicalDamageTaken")]
            public int MagicalDamageTaken { get; set; }

            [JsonProperty("physicalDamageTaken")]
            public int PhysicalDamageTaken { get; set; }

            [JsonProperty("trueDamageTaken")]
            public int TrueDamageTaken { get; set; }

            [JsonProperty("goldEarned")]
            public int GoldEarned { get; set; }

            [JsonProperty("goldSpent")]
            public int GoldSpent { get; set; }

            [JsonProperty("turretKills")]
            public int TurretKills { get; set; }

            [JsonProperty("inhibitorKills")]
            public int InhibitorKills { get; set; }

            [JsonProperty("totalMinionsKilled")]
            public int TotalMinionsKilled { get; set; }

            [JsonProperty("neutralMinionsKilled")]
            public int NeutralMinionsKilled { get; set; }

            [JsonProperty("neutralMinionsKilledTeamJungle")]
            public int NeutralMinionsKilledTeamJungle { get; set; }

            [JsonProperty("neutralMinionsKilledEnemyJungle")]
            public int NeutralMinionsKilledEnemyJungle { get; set; }

            [JsonProperty("totalTimeCrowdControlDealt")]
            public int TotalTimeCrowdControlDealt { get; set; }

            [JsonProperty("champLevel")]
            public int ChampLevel { get; set; }

            [JsonProperty("visionWardsBoughtInGame")]
            public int VisionWardsBoughtInGame { get; set; }

            [JsonProperty("sightWardsBoughtInGame")]
            public int SightWardsBoughtInGame { get; set; }

            [JsonProperty("wardsPlaced")]
            public int WardsPlaced { get; set; }

            [JsonProperty("wardsKilled")]
            public int WardsKilled { get; set; }

            [JsonProperty("firstBloodKill")]
            public bool FirstBloodKill { get; set; }

            [JsonProperty("firstBloodAssist")]
            public bool FirstBloodAssist { get; set; }

            [JsonProperty("firstTowerKill")]
            public bool FirstTowerKill { get; set; }

            [JsonProperty("firstTowerAssist")]
            public bool FirstTowerAssist { get; set; }

            [JsonProperty("firstInhibitorKill")]
            public bool FirstInhibitorKill { get; set; }

            [JsonProperty("firstInhibitorAssist")]
            public bool FirstInhibitorAssist { get; set; }

            [JsonProperty("combatPlayerScore")]
            public int CombatPlayerScore { get; set; }

            [JsonProperty("objectivePlayerScore")]
            public int ObjectivePlayerScore { get; set; }

            [JsonProperty("totalPlayerScore")]
            public int TotalPlayerScore { get; set; }

            [JsonProperty("totalScoreRank")]
            public int TotalScoreRank { get; set; }

            [JsonProperty("playerScore0")]
            public int PlayerScore0 { get; set; }

            [JsonProperty("playerScore1")]
            public int PlayerScore1 { get; set; }

            [JsonProperty("playerScore2")]
            public int PlayerScore2 { get; set; }

            [JsonProperty("playerScore3")]
            public int PlayerScore3 { get; set; }

            [JsonProperty("playerScore4")]
            public int PlayerScore4 { get; set; }

            [JsonProperty("playerScore5")]
            public int PlayerScore5 { get; set; }

            [JsonProperty("playerScore6")]
            public int PlayerScore6 { get; set; }

            [JsonProperty("playerScore7")]
            public int PlayerScore7 { get; set; }

            [JsonProperty("playerScore8")]
            public int PlayerScore8 { get; set; }

            [JsonProperty("playerScore9")]
            public int PlayerScore9 { get; set; }

            [JsonProperty("perk0")]
            public int Perk0 { get; set; }

            [JsonProperty("perk0Var1")]
            public int Perk0Var1 { get; set; }

            [JsonProperty("perk0Var2")]
            public int Perk0Var2 { get; set; }

            [JsonProperty("perk0Var3")]
            public int Perk0Var3 { get; set; }

            [JsonProperty("perk1")]
            public int Perk1 { get; set; }

            [JsonProperty("perk1Var1")]
            public int Perk1Var1 { get; set; }

            [JsonProperty("perk1Var2")]
            public int Perk1Var2 { get; set; }

            [JsonProperty("perk1Var3")]
            public int Perk1Var3 { get; set; }

            [JsonProperty("perk2")]
            public int Perk2 { get; set; }

            [JsonProperty("perk2Var1")]
            public int Perk2Var1 { get; set; }

            [JsonProperty("perk2Var2")]
            public int Perk2Var2 { get; set; }

            [JsonProperty("perk2Var3")]
            public int Perk2Var3 { get; set; }

            [JsonProperty("perk3")]
            public int Perk3 { get; set; }

            [JsonProperty("perk3Var1")]
            public int Perk3Var1 { get; set; }

            [JsonProperty("perk3Var2")]
            public int Perk3Var2 { get; set; }

            [JsonProperty("perk3Var3")]
            public int Perk3Var3 { get; set; }

            [JsonProperty("perk4")]
            public int Perk4 { get; set; }

            [JsonProperty("perk4Var1")]
            public int Perk4Var1 { get; set; }

            [JsonProperty("perk4Var2")]
            public int Perk4Var2 { get; set; }

            [JsonProperty("perk4Var3")]
            public int Perk4Var3 { get; set; }

            [JsonProperty("perk5")]
            public int Perk5 { get; set; }

            [JsonProperty("perk5Var1")]
            public int Perk5Var1 { get; set; }

            [JsonProperty("perk5Var2")]
            public int Perk5Var2 { get; set; }

            [JsonProperty("perk5Var3")]
            public int Perk5Var3 { get; set; }

            [JsonProperty("perkPrimaryStyle")]
            public int PerkPrimaryStyle { get; set; }

            [JsonProperty("perkSubStyle")]
            public int PerkSubStyle { get; set; }

            [JsonProperty("statPerk0")]
            public int StatPerk0 { get; set; }

            [JsonProperty("statPerk1")]
            public int StatPerk1 { get; set; }

            [JsonProperty("statPerk2")]
            public int StatPerk2 { get; set; }
        }

        public class CreepsPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class XpPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class GoldPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class CsDiffPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class XpDiffPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class DamageTakenPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class DamageTakenDiffPerMinDeltas
        {
            [JsonProperty("10-20")]
            public double _1020 { get; set; }

            [JsonProperty("0-10")]
            public double _010 { get; set; }

            [JsonProperty("30-end")]
            public double _30End { get; set; }

            [JsonProperty("20-30")]
            public double _2030 { get; set; }
        }

        public class Timeline
        {
            [JsonProperty("participantId")]
            public int ParticipantId { get; set; }

            [JsonProperty("creepsPerMinDeltas")]
            public CreepsPerMinDeltas CreepsPerMinDeltas { get; set; }

            [JsonProperty("xpPerMinDeltas")]
            public XpPerMinDeltas XpPerMinDeltas { get; set; }

            [JsonProperty("goldPerMinDeltas")]
            public GoldPerMinDeltas GoldPerMinDeltas { get; set; }

            [JsonProperty("csDiffPerMinDeltas")]
            public CsDiffPerMinDeltas CsDiffPerMinDeltas { get; set; }

            [JsonProperty("xpDiffPerMinDeltas")]
            public XpDiffPerMinDeltas XpDiffPerMinDeltas { get; set; }

            [JsonProperty("damageTakenPerMinDeltas")]
            public DamageTakenPerMinDeltas DamageTakenPerMinDeltas { get; set; }

            [JsonProperty("damageTakenDiffPerMinDeltas")]
            public DamageTakenDiffPerMinDeltas DamageTakenDiffPerMinDeltas { get; set; }

            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("lane")]
            public string Lane { get; set; }
        }

        public class Participant
        {
            [JsonProperty("participantId")]
            public int ParticipantId { get; set; }

            [JsonProperty("teamId")]
            public int TeamId { get; set; }

            [JsonProperty("championId")]
            public int ChampionId { get; set; }

            [JsonProperty("spell1Id")]
            public int Spell1Id { get; set; }

            [JsonProperty("spell2Id")]
            public int Spell2Id { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }

            [JsonProperty("timeline")]
            public Timeline Timeline { get; set; }
        }

        public class Player
        {
            [JsonProperty("platformId")]
            public string PlatformId { get; set; }

            [JsonProperty("accountId")]
            public string AccountId { get; set; }

            [JsonProperty("summonerName")]
            public string SummonerName { get; set; }

            [JsonProperty("summonerId")]
            public string SummonerId { get; set; }

            [JsonProperty("currentPlatformId")]
            public string CurrentPlatformId { get; set; }

            [JsonProperty("currentAccountId")]
            public string CurrentAccountId { get; set; }

            [JsonProperty("matchHistoryUri")]
            public string MatchHistoryUri { get; set; }

            [JsonProperty("profileIcon")]
            public int ProfileIcon { get; set; }
        }

        public class ParticipantIdentity
        {
            [JsonProperty("participantId")]
            public int ParticipantId { get; set; }

            [JsonProperty("player")]
            public Player Player { get; set; }
        }

        public class Root
        {
            [JsonProperty("gameId")]
            public long GameId { get; set; }

            [JsonProperty("platformId")]
            public string PlatformId { get; set; }

            [JsonProperty("gameCreation")]
            public long GameCreation { get; set; }

            [JsonProperty("gameDuration")]
            public int GameDuration { get; set; }

            [JsonProperty("queueId")]
            public int QueueId { get; set; }

            [JsonProperty("mapId")]
            public int MapId { get; set; }

            [JsonProperty("seasonId")]
            public int SeasonId { get; set; }

            [JsonProperty("gameVersion")]
            public string GameVersion { get; set; }

            [JsonProperty("gameMode")]
            public string GameMode { get; set; }

            [JsonProperty("gameType")]
            public string GameType { get; set; }

            [JsonProperty("teams")]
            public List<Team> Teams { get; set; }

            [JsonProperty("participants")]
            public List<Participant> Participants { get; set; }

            [JsonProperty("participantIdentities")]
            public List<ParticipantIdentity> ParticipantIdentities { get; set; }
        }
        //Getting the actual match id
        public class Match
        {
            [JsonProperty("platformId")]
            public string PlatformId { get; set; }

            [JsonProperty("gameId")]
            public object GameId { get; set; }

            [JsonProperty("champion")]
            public int Champion { get; set; }

            [JsonProperty("queue")]
            public int Queue { get; set; }

            [JsonProperty("season")]
            public int Season { get; set; }

            [JsonProperty("timestamp")]
            public object Timestamp { get; set; }

            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("lane")]
            public string Lane { get; set; }
        }

        public class MatchRoot
        {
            [JsonProperty("matches")]
            public List<Match> Matches { get; set; }

            [JsonProperty("startIndex")]
            public int StartIndex { get; set; }

            [JsonProperty("endIndex")]
            public int EndIndex { get; set; }

            [JsonProperty("totalGames")]
            public int TotalGames { get; set; }
        }

        public String apiGameMatchCall()
        {
            string accountID = "2dSPXLYz2nn_KnDNxfCrw6bm4RtQPgtE4X4gGmqaojTJvko";
            String API_KEY = "RGAPI-bb6d7a3e-eb72-4306-a5f1-010be3f38d48";

            String SummonerUrl = "https://euw1.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountID + "?api_key=" + API_KEY;

            return SummonerUrl;

        }

        public String getMatchID() 
        {
            String json = new WebClient().DownloadString(apiGameMatchCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastGameid = dynamicobject.matches;

            foreach(var obj in userLastGameid)
            {
                return obj.gameId;
            }
            
            return userLastGameid;
        }

        public String apiMatchIdCall()
        {
            String matchid = getMatchID();
            String API_KEY = "RGAPI-bb6d7a3e-eb72-4306-a5f1-010be3f38d48";

            String GameUrl = "https://euw1.api.riotgames.com/lol/match/v4/matches/" + matchid + "?api_key=" + API_KEY;

            return GameUrl;
        }

        public DateTime getTimestampPrev()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);
            var userTimestamp = dynamicobject.participants;
            foreach (var objname in userTimestamp)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTime = dtDateTime.AddMilliseconds(objname.timeline).ToLocalTime();
                    return dtDateTime;
                }
            }
            return userTimestamp.timeline;
        }

        public string matchHistoryTimestamp()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.timestamp;
            }

            return matchesHistory;
        }

        
        public string matchHistoryTotalGames()
        {
            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userTotalGames = dynamicobject.totalGames.ToString();

            return userTotalGames;
        }

        public string matchHistoryPosition()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.platformId;
            }

            return matchesHistory;
        }

        public string matchHistoryGameid()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.gameId;
            }

            return matchesHistory;
        }

        public string matchHistoryChamp()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.champion;
            }

            return matchesHistory;
        }

        public string matchHistoryQueue()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.queue;
            }

            return matchesHistory;
        }

        public string matchHistorySeason()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.season;
            }

            return matchesHistory;
        }
        public string matchHistoryLane()
        {

            var json = new WebClient().DownloadString(apiGameMatchCall());

            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var matchesHistory = dynamicobject.matches;

            foreach (var objmatch in matchesHistory)
            {
                return objmatch.lane;
            }

            return matchesHistory;
        }


        public Object getLastGameItems0()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item0;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems1()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item1;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems2()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item2;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems3()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item3;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems4()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item4;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems5()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item5;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object getLastGameItems6()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.item6;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserTrueDamage() 
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.trueDamageDealt;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserPhysicalDamage()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.physicalDamageDealt;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserMagicDamage()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.magicDamageDealt;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserTrueDamageTaken()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.trueDamageTaken;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserPhysicalDamageTaken()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.physicalDamageTaken;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserMagicDamageTaken()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.magicalDamageTaken;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserTotalDamageTaken()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.totalDamageTaken;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserTotalDamageDealt()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.totalDamageDealt;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public int getUserTotalHealing()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastItems = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastItems)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.totalHeal;
                        }
                    }
                }
            }
            return userLastItems;
        }

        public Object lastGameWinLoss() 
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);
            var userLastgame = dynamicobject.teams;
            var userName = dynamicobject.participantIdentities;
            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {


                    foreach (var obj in userLastgame)
                    {
                        if (obj != null)
                        {
                            if (obj.win == "Fail")
                            {
                                return "Loss";
                            }
                            else
                            {
                                return "Win";
                            }
                        }
                    }
                }
                
            }
            return 404;
        }
            

        public String lastGameposition()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);

            var userLastGame = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;

            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastGame)
                    {
                        if(objname.participantId == obj.participantId)
                        {
                            return obj.timeline.role;
                        }
                    }
                }
            }
            return "404";
        }

        public Object lastGameChampion()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);
            
            var userLastGame = dynamicobject.participants;
            var userName = dynamicobject.participantIdentities;

            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userLastGame)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.championId;
                        }
                    }
                }
            }
            return 404;
        }

        public double kdaRatio()
        {
            var kdaratio = ((double)lastGameKills() + (double)lastGameAssists()) / (double)lastGameDeaths();
            return Math.Round(kdaratio, 2);
        }

        public JValue lastGameKills()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);

            var userKDA = dynamicObject.participants;
            var userName = dynamicObject.participantIdentities;

            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userKDA)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.kills;
                        }
                    }
                }
            }
            return userKDA;
        }
        public JValue lastGameDeaths()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
            var userKDA = dynamicObject.participants;
            var userName = dynamicObject.participantIdentities;

            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userKDA)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.deaths;
                        }
                    }
                }
            }
            return userKDA;
        }

        public JValue lastGameAssists()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
            var userKDA = dynamicObject.participants;
            var userName = dynamicObject.participantIdentities;

            foreach (var objname in userName)
            {
                if (objname.player.summonerName == "sneakyfox9")
                {
                    foreach (var obj in userKDA)
                    {
                        if (objname.participantId == obj.participantId)
                        {
                            return obj.stats.assists;
                        }
                    }
                }
            }
            return userKDA;
        }

        public Object matchHistory()
        {
            String json = new WebClient().DownloadString(apiMatchIdCall());
            var dynamicobject = JsonConvert.DeserializeObject<dynamic>(json);
            var userTotalGames = dynamicobject.participantIdentities;
            foreach (var obj in userTotalGames)
            {
                if (obj.player.summonerName == "sneakyfox9") 
                {
                   string name = obj.player.summonerName;
                   return name;
                }


            }
            return userTotalGames;
        }

        public void OnGet()
        {
        }

    }
}
