using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    /// <summary>
    /// Item Object
    /// </summary>
    public struct Item
    {
        /// <summary>
        /// Item Count
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Item Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}
