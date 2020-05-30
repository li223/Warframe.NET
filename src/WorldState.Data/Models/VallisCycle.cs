using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class VallisCycle : Cycle
    {
        [JsonProperty("isWarm")]
        public bool IsWarm { get; private set; }
    }
}
