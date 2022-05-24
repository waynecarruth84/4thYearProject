using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using GamingAnalytics.Pages;

namespace GamingAnalytics.Pages
{
    public class champsModel : PageModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Info
        {
            [JsonProperty("attack")]
            public int Attack { get; set; }

            [JsonProperty("defense")]
            public int Defense { get; set; }

            [JsonProperty("magic")]
            public int Magic { get; set; }

            [JsonProperty("difficulty")]
            public int Difficulty { get; set; }
        }

        public class Image
        {
            [JsonProperty("full")]
            public string Full { get; set; }

            [JsonProperty("sprite")]
            public string Sprite { get; set; }

            [JsonProperty("group")]
            public string Group { get; set; }

            [JsonProperty("x")]
            public int X { get; set; }

            [JsonProperty("y")]
            public int Y { get; set; }

            [JsonProperty("w")]
            public int W { get; set; }

            [JsonProperty("h")]
            public int H { get; set; }
        }

        public class Stats
        {
            [JsonProperty("hp")]
            public int Hp { get; set; }

            [JsonProperty("hpperlevel")]
            public int Hpperlevel { get; set; }

            [JsonProperty("mp")]
            public int Mp { get; set; }

            [JsonProperty("mpperlevel")]
            public int Mpperlevel { get; set; }

            [JsonProperty("movespeed")]
            public int Movespeed { get; set; }

            [JsonProperty("armor")]
            public int Armor { get; set; }

            [JsonProperty("armorperlevel")]
            public double Armorperlevel { get; set; }

            [JsonProperty("spellblock")]
            public int Spellblock { get; set; }

            [JsonProperty("spellblockperlevel")]
            public double Spellblockperlevel { get; set; }

            [JsonProperty("attackrange")]
            public int Attackrange { get; set; }

            [JsonProperty("hpregen")]
            public int Hpregen { get; set; }

            [JsonProperty("hpregenperlevel")]
            public int Hpregenperlevel { get; set; }

            [JsonProperty("mpregen")]
            public int Mpregen { get; set; }

            [JsonProperty("mpregenperlevel")]
            public int Mpregenperlevel { get; set; }

            [JsonProperty("crit")]
            public int Crit { get; set; }

            [JsonProperty("critperlevel")]
            public int Critperlevel { get; set; }

            [JsonProperty("attackdamage")]
            public int Attackdamage { get; set; }

            [JsonProperty("attackdamageperlevel")]
            public int Attackdamageperlevel { get; set; }

            [JsonProperty("attackspeedperlevel")]
            public double Attackspeedperlevel { get; set; }

            [JsonProperty("attackspeed")]
            public double Attackspeed { get; set; }
        }

        public class Aatrox
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ahri
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Akali
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Alistar
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Amumu
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Anivia
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Annie
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Aphelios
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ashe
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class AurelionSol
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Azir
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Bard
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Blitzcrank
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Brand
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Braum
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Caitlyn
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Camille
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Cassiopeia
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Chogath
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Corki
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Darius
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Diana
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Draven
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class DrMundo
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ekko
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Elise
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Evelynn
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ezreal
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Fiddlesticks
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Fiora
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Fizz
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Galio
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Gangplank
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Garen
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Gnar
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Gragas
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Graves
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Hecarim
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Heimerdinger
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Illaoi
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Irelia
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ivern
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Janna
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class JarvanIV
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Jax
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Jayce
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Jhin
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Jinx
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kaisa
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kalista
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Karma
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Karthus
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kassadin
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Katarina
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kayle
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kayn
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kennen
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Khazix
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kindred
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Kled
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class KogMaw
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Leblanc
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class LeeSin
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Leona
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Lillia
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Lissandra
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Lucian
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Lulu
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Lux
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Malphite
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Malzahar
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Maokai
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class MasterYi
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class MissFortune
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class MonkeyKing
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Mordekaiser
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Morgana
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nami
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nasus
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nautilus
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Neeko
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nidalee
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nocturne
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Nunu
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Olaf
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Orianna
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ornn
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Pantheon
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Poppy
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Pyke
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Qiyana
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Quinn
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Rakan
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Rammus
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class RekSai
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Rell
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Renekton
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Rengar
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Riven
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Rumble
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ryze
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Samira
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sejuani
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Senna
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Seraphine
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sett
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Shaco
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Shen
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Shyvana
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Singed
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sion
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sivir
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Skarner
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sona
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Soraka
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Swain
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Sylas
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Syndra
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class TahmKench
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Taliyah
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Talon
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Taric
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Teemo
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Thresh
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Tristana
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Trundle
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Tryndamere
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class TwistedFate
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Twitch
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Udyr
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Urgot
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Varus
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Vayne
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Veigar
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Velkoz
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Vi
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Viego
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Viktor
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Vladimir
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Volibear
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Warwick
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Xayah
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Xerath
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class XinZhao
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Yasuo
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Yone
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Yorick
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Yuumi
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Zac
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Zed
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Ziggs
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Zilean
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Zoe
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Zyra
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("blurb")]
            public string Blurb { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }

            [JsonProperty("tags")]
            public List<string> Tags { get; set; }

            [JsonProperty("partype")]
            public string Partype { get; set; }

            [JsonProperty("stats")]
            public Stats Stats { get; set; }
        }

        public class Data
        {
            [JsonProperty("Aatrox")]
            public Aatrox Aatrox { get; set; }

            [JsonProperty("Ahri")]
            public Ahri Ahri { get; set; }

            [JsonProperty("Akali")]
            public Akali Akali { get; set; }

            [JsonProperty("Alistar")]
            public Alistar Alistar { get; set; }

            [JsonProperty("Amumu")]
            public Amumu Amumu { get; set; }

            [JsonProperty("Anivia")]
            public Anivia Anivia { get; set; }

            [JsonProperty("Annie")]
            public Annie Annie { get; set; }

            [JsonProperty("Aphelios")]
            public Aphelios Aphelios { get; set; }

            [JsonProperty("Ashe")]
            public Ashe Ashe { get; set; }

            [JsonProperty("AurelionSol")]
            public AurelionSol AurelionSol { get; set; }

            [JsonProperty("Azir")]
            public Azir Azir { get; set; }

            [JsonProperty("Bard")]
            public Bard Bard { get; set; }

            [JsonProperty("Blitzcrank")]
            public Blitzcrank Blitzcrank { get; set; }

            [JsonProperty("Brand")]
            public Brand Brand { get; set; }

            [JsonProperty("Braum")]
            public Braum Braum { get; set; }

            [JsonProperty("Caitlyn")]
            public Caitlyn Caitlyn { get; set; }

            [JsonProperty("Camille")]
            public Camille Camille { get; set; }

            [JsonProperty("Cassiopeia")]
            public Cassiopeia Cassiopeia { get; set; }

            [JsonProperty("Chogath")]
            public Chogath Chogath { get; set; }

            [JsonProperty("Corki")]
            public Corki Corki { get; set; }

            [JsonProperty("Darius")]
            public Darius Darius { get; set; }

            [JsonProperty("Diana")]
            public Diana Diana { get; set; }

            [JsonProperty("Draven")]
            public Draven Draven { get; set; }

            [JsonProperty("DrMundo")]
            public DrMundo DrMundo { get; set; }

            [JsonProperty("Ekko")]
            public Ekko Ekko { get; set; }

            [JsonProperty("Elise")]
            public Elise Elise { get; set; }

            [JsonProperty("Evelynn")]
            public Evelynn Evelynn { get; set; }

            [JsonProperty("Ezreal")]
            public Ezreal Ezreal { get; set; }

            [JsonProperty("Fiddlesticks")]
            public Fiddlesticks Fiddlesticks { get; set; }

            [JsonProperty("Fiora")]
            public Fiora Fiora { get; set; }

            [JsonProperty("Fizz")]
            public Fizz Fizz { get; set; }

            [JsonProperty("Galio")]
            public Galio Galio { get; set; }

            [JsonProperty("Gangplank")]
            public Gangplank Gangplank { get; set; }

            [JsonProperty("Garen")]
            public Garen Garen { get; set; }

            [JsonProperty("Gnar")]
            public Gnar Gnar { get; set; }

            [JsonProperty("Gragas")]
            public Gragas Gragas { get; set; }

            [JsonProperty("Graves")]
            public Graves Graves { get; set; }

            [JsonProperty("Hecarim")]
            public Hecarim Hecarim { get; set; }

            [JsonProperty("Heimerdinger")]
            public Heimerdinger Heimerdinger { get; set; }

            [JsonProperty("Illaoi")]
            public Illaoi Illaoi { get; set; }

            [JsonProperty("Irelia")]
            public Irelia Irelia { get; set; }

            [JsonProperty("Ivern")]
            public Ivern Ivern { get; set; }

            [JsonProperty("Janna")]
            public Janna Janna { get; set; }

            [JsonProperty("JarvanIV")]
            public JarvanIV JarvanIV { get; set; }

            [JsonProperty("Jax")]
            public Jax Jax { get; set; }

            [JsonProperty("Jayce")]
            public Jayce Jayce { get; set; }

            [JsonProperty("Jhin")]
            public Jhin Jhin { get; set; }

            [JsonProperty("Jinx")]
            public Jinx Jinx { get; set; }

            [JsonProperty("Kaisa")]
            public Kaisa Kaisa { get; set; }

            [JsonProperty("Kalista")]
            public Kalista Kalista { get; set; }

            [JsonProperty("Karma")]
            public Karma Karma { get; set; }

            [JsonProperty("Karthus")]
            public Karthus Karthus { get; set; }

            [JsonProperty("Kassadin")]
            public Kassadin Kassadin { get; set; }

            [JsonProperty("Katarina")]
            public Katarina Katarina { get; set; }

            [JsonProperty("Kayle")]
            public Kayle Kayle { get; set; }

            [JsonProperty("Kayn")]
            public Kayn Kayn { get; set; }

            [JsonProperty("Kennen")]
            public Kennen Kennen { get; set; }

            [JsonProperty("Khazix")]
            public Khazix Khazix { get; set; }

            [JsonProperty("Kindred")]
            public Kindred Kindred { get; set; }

            [JsonProperty("Kled")]
            public Kled Kled { get; set; }

            [JsonProperty("KogMaw")]
            public KogMaw KogMaw { get; set; }

            [JsonProperty("Leblanc")]
            public Leblanc Leblanc { get; set; }

            [JsonProperty("LeeSin")]
            public LeeSin LeeSin { get; set; }

            [JsonProperty("Leona")]
            public Leona Leona { get; set; }

            [JsonProperty("Lillia")]
            public Lillia Lillia { get; set; }

            [JsonProperty("Lissandra")]
            public Lissandra Lissandra { get; set; }

            [JsonProperty("Lucian")]
            public Lucian Lucian { get; set; }

            [JsonProperty("Lulu")]
            public Lulu Lulu { get; set; }

            [JsonProperty("Lux")]
            public Lux Lux { get; set; }

            [JsonProperty("Malphite")]
            public Malphite Malphite { get; set; }

            [JsonProperty("Malzahar")]
            public Malzahar Malzahar { get; set; }

            [JsonProperty("Maokai")]
            public Maokai Maokai { get; set; }

            [JsonProperty("MasterYi")]
            public MasterYi MasterYi { get; set; }

            [JsonProperty("MissFortune")]
            public MissFortune MissFortune { get; set; }

            [JsonProperty("MonkeyKing")]
            public MonkeyKing MonkeyKing { get; set; }

            [JsonProperty("Mordekaiser")]
            public Mordekaiser Mordekaiser { get; set; }

            [JsonProperty("Morgana")]
            public Morgana Morgana { get; set; }

            [JsonProperty("Nami")]
            public Nami Nami { get; set; }

            [JsonProperty("Nasus")]
            public Nasus Nasus { get; set; }

            [JsonProperty("Nautilus")]
            public Nautilus Nautilus { get; set; }

            [JsonProperty("Neeko")]
            public Neeko Neeko { get; set; }

            [JsonProperty("Nidalee")]
            public Nidalee Nidalee { get; set; }

            [JsonProperty("Nocturne")]
            public Nocturne Nocturne { get; set; }

            [JsonProperty("Nunu")]
            public Nunu Nunu { get; set; }

            [JsonProperty("Olaf")]
            public Olaf Olaf { get; set; }

            [JsonProperty("Orianna")]
            public Orianna Orianna { get; set; }

            [JsonProperty("Ornn")]
            public Ornn Ornn { get; set; }

            [JsonProperty("Pantheon")]
            public Pantheon Pantheon { get; set; }

            [JsonProperty("Poppy")]
            public Poppy Poppy { get; set; }

            [JsonProperty("Pyke")]
            public Pyke Pyke { get; set; }

            [JsonProperty("Qiyana")]
            public Qiyana Qiyana { get; set; }

            [JsonProperty("Quinn")]
            public Quinn Quinn { get; set; }

            [JsonProperty("Rakan")]
            public Rakan Rakan { get; set; }

            [JsonProperty("Rammus")]
            public Rammus Rammus { get; set; }

            [JsonProperty("RekSai")]
            public RekSai RekSai { get; set; }

            [JsonProperty("Rell")]
            public Rell Rell { get; set; }

            [JsonProperty("Renekton")]
            public Renekton Renekton { get; set; }

            [JsonProperty("Rengar")]
            public Rengar Rengar { get; set; }

            [JsonProperty("Riven")]
            public Riven Riven { get; set; }

            [JsonProperty("Rumble")]
            public Rumble Rumble { get; set; }

            [JsonProperty("Ryze")]
            public Ryze Ryze { get; set; }

            [JsonProperty("Samira")]
            public Samira Samira { get; set; }

            [JsonProperty("Sejuani")]
            public Sejuani Sejuani { get; set; }

            [JsonProperty("Senna")]
            public Senna Senna { get; set; }

            [JsonProperty("Seraphine")]
            public Seraphine Seraphine { get; set; }

            [JsonProperty("Sett")]
            public Sett Sett { get; set; }

            [JsonProperty("Shaco")]
            public Shaco Shaco { get; set; }

            [JsonProperty("Shen")]
            public Shen Shen { get; set; }

            [JsonProperty("Shyvana")]
            public Shyvana Shyvana { get; set; }

            [JsonProperty("Singed")]
            public Singed Singed { get; set; }

            [JsonProperty("Sion")]
            public Sion Sion { get; set; }

            [JsonProperty("Sivir")]
            public Sivir Sivir { get; set; }

            [JsonProperty("Skarner")]
            public Skarner Skarner { get; set; }

            [JsonProperty("Sona")]
            public Sona Sona { get; set; }

            [JsonProperty("Soraka")]
            public Soraka Soraka { get; set; }

            [JsonProperty("Swain")]
            public Swain Swain { get; set; }

            [JsonProperty("Sylas")]
            public Sylas Sylas { get; set; }

            [JsonProperty("Syndra")]
            public Syndra Syndra { get; set; }

            [JsonProperty("TahmKench")]
            public TahmKench TahmKench { get; set; }

            [JsonProperty("Taliyah")]
            public Taliyah Taliyah { get; set; }

            [JsonProperty("Talon")]
            public Talon Talon { get; set; }

            [JsonProperty("Taric")]
            public Taric Taric { get; set; }

            [JsonProperty("Teemo")]
            public Teemo Teemo { get; set; }

            [JsonProperty("Thresh")]
            public Thresh Thresh { get; set; }

            [JsonProperty("Tristana")]
            public Tristana Tristana { get; set; }

            [JsonProperty("Trundle")]
            public Trundle Trundle { get; set; }

            [JsonProperty("Tryndamere")]
            public Tryndamere Tryndamere { get; set; }

            [JsonProperty("TwistedFate")]
            public TwistedFate TwistedFate { get; set; }

            [JsonProperty("Twitch")]
            public Twitch Twitch { get; set; }

            [JsonProperty("Udyr")]
            public Udyr Udyr { get; set; }

            [JsonProperty("Urgot")]
            public Urgot Urgot { get; set; }

            [JsonProperty("Varus")]
            public Varus Varus { get; set; }

            [JsonProperty("Vayne")]
            public Vayne Vayne { get; set; }

            [JsonProperty("Veigar")]
            public Veigar Veigar { get; set; }

            [JsonProperty("Velkoz")]
            public Velkoz Velkoz { get; set; }

            [JsonProperty("Vi")]
            public Vi Vi { get; set; }

            [JsonProperty("Viego")]
            public Viego Viego { get; set; }

            [JsonProperty("Viktor")]
            public Viktor Viktor { get; set; }

            [JsonProperty("Vladimir")]
            public Vladimir Vladimir { get; set; }

            [JsonProperty("Volibear")]
            public Volibear Volibear { get; set; }

            [JsonProperty("Warwick")]
            public Warwick Warwick { get; set; }

            [JsonProperty("Xayah")]
            public Xayah Xayah { get; set; }

            [JsonProperty("Xerath")]
            public Xerath Xerath { get; set; }

            [JsonProperty("XinZhao")]
            public XinZhao XinZhao { get; set; }

            [JsonProperty("Yasuo")]
            public Yasuo Yasuo { get; set; }

            [JsonProperty("Yone")]
            public Yone Yone { get; set; }

            [JsonProperty("Yorick")]
            public Yorick Yorick { get; set; }

            [JsonProperty("Yuumi")]
            public Yuumi Yuumi { get; set; }

            [JsonProperty("Zac")]
            public Zac Zac { get; set; }

            [JsonProperty("Zed")]
            public Zed Zed { get; set; }

            [JsonProperty("Ziggs")]
            public Ziggs Ziggs { get; set; }

            [JsonProperty("Zilean")]
            public Zilean Zilean { get; set; }

            [JsonProperty("Zoe")]
            public Zoe Zoe { get; set; }

            [JsonProperty("Zyra")]
            public Zyra Zyra { get; set; }
        }

        public class Root
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("format")]
            public string Format { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public Object championsBasedOnId()
        {
            var dynamic = JsonConvert.DeserializeObject<dynamic>(System.IO.File.ReadAllText(@"C:\Users\Wayne The Goat\source\repos\GamingAnalytics\GamingAnalytics\champion.json"));
            var champs = dynamic;

            foreach (var obj in champs)
            {
                while (obj != null)
                {
                    var champKey = obj.key;
                    if (champKey == null)
                    {
                        var champName = obj.id;
                        return champName;
                    }

                }
            }
            return champs;

        }

        public void OnGet()
        {
        }
    }
}
