using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    /// <summary>
    /// An item in the void trader's inventory
    /// </summary>
    public class VoidTraderItem
    {
        /// <summary>
        /// The item's name
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; private set; }

        /// <summary>
        /// Ducats cost
        /// </summary>
        [JsonProperty("ducats")]
        public int Ducats { get; private set; }

        /// <summary>
        /// Credits Cost
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; private set; }
    }


}
