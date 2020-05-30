using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Cycle
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; private set; }
    }
}
