using Newtonsoft.Json;
using System;

namespace WorldState.Data.Models
{
    public class PersistentEnemy
    {
        [JsonProperty("locationTag")]
        public string LocationTag { get; private set; }

        [JsonProperty("agentType")]
        public string AgentType { get; private set; }
    
        [JsonProperty("rank")]
        public int Rank { get; private set; }

        [JsonProperty("healthPercent")]
        public double HealthPercentage { get; private set; }

        [JsonProperty("fleeDamage")]
        public double FleeDamage { get; private set; }

        [JsonProperty("region")]
        public string Region { get; private set; }

        [JsonProperty("lastDiscoveredTime")]
        public DateTime LastDiscoveredTimestamp { get; private set; }

        [JsonProperty("lastDiscoveredAt")]
        public string LastDiscoveredLocation { get; private set; }

        [JsonProperty("isDiscovered")]
        public bool IsDiscovered { get; private set; }

        [JsonProperty("isUsingTicketing")]
        public bool IsUsingTicketing { get; private set; }

        [JsonProperty("pid")]
        public string PId { get; private set; }
    }
}
