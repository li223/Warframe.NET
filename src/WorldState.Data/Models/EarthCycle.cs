using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class EarthCycle : Cycle
    {
        [JsonProperty("isDay")]
        public bool IsDay { get; private set; }
    }
}
