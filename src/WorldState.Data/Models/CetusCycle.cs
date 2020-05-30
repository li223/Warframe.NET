using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class CetusCycle : Cycle
    {
        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("isDay")]
        public bool IsDay { get; private set; }

        [JsonProperty("state")]
        public string State { get; private set; }

        [JsonProperty("isCetus")]
        public bool IsCetus { get; private set; }

        [JsonProperty("shortString")]
        public string ShortString { get; private set; }
    }
}
