using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
    public class WorldState
    {
        [JsonProperty("timestamp")]
        public DateTime CurrentTimestamp { get; private set; }

        [JsonProperty("news")]
        public IEnumerable<News> News { get; private set; }

        [JsonProperty("events")]
        public IEnumerable<Event> Events { get; private set; }

        [JsonProperty("sortie")]
        public Sortie Sortie { get; private set; }

        [JsonProperty("syndicateMissions")]
        public IEnumerable<SyndicateMission> SyndicateMissions { get; private set; }

        [JsonProperty("fissures")]
        public IEnumerable<Fissure> Fissures { get; private set; }

        [JsonProperty("globalUpgrades")]
        public IEnumerable<GlobalUpgrade> GlobalUpgrades { get; private set; }

        [JsonProperty("flashSales")]
        public IEnumerable<FlashSale> FlashSales { get; private set; }

        [JsonProperty("invasions")]
        public IEnumerable<Invasion> Invasions { get; private set; }

        [JsonProperty("voidTrader")]
        public VoidTrader VoidTrader { get; private set; }

        [JsonProperty("dailyDeals")]
        public IEnumerable<DailyDeal> DailyDeals { get; private set; }

        [JsonProperty("simaris")]
        public Simaris Simaris { get; private set; }

        [JsonProperty("conclaveChallenges")]
        public IEnumerable<ConclaveChallenge> ConclaveChallenges { get; private set; }

        [JsonProperty("persistentEnemies")]
        public IEnumerable<PersistentEnemy> PersistentEnemies { get; private set; }

        [JsonProperty("earthCycle")]
        public EarthCycle EarthCycle { get; private set; }

        [JsonProperty("cetusCycle")]
        public CetusCycle CetusCycle { get; private set; }

        [JsonProperty("vallisCycle")]
        public VallisCycle VallisCycle { get; private set; }

        [JsonProperty("constructionProgress")]
        public ConstructionProgress ConstructionProgress { get; private set; }

        [JsonProperty("nightwave")]
        public Nightwave Nightwave { get; private set; }

        [JsonProperty("arbitration")]
        public Arbitration Arbitration { get; private set; }

        [JsonProperty("kuva")]
        public Kuva Kuva { get; private set; }
    }
}
