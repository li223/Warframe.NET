using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    public class Kuva : Arbitration
    {
        [JsonProperty("node_type")]
        public string NodeType { get; private set; }
    }
}
