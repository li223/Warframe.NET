using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldState.Data.Models
{
    /// <summary>
    /// Arbitration object
    /// </summary>
    public class Arbitration
    {
        /// <summary>
        /// Time of activation
        /// </summary>
        [JsonProperty("activation")]
        public DateTime ActivationTimestamp { get; private set; }

        /// <summary>
        /// Time of expiry
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime ExpiryTimestamp { get; private set; }

        /// <summary>
        /// Name of the node the mission is on
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }

        /// <summary>
        /// Name of the enemy the mission is against
        /// </summary>
        [JsonProperty("enemy")]
        public string Enemy { get; private set; }

        /// <summary>
        /// Mission type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// If the mission requires the use of an Archwing
        /// </summary>
        [JsonProperty("archwing")]
        public bool RequiresArchwing { get; private set; }

        /// <summary>
        /// If the mission requires the use of a Sharkwing
        /// </summary>
        [JsonProperty("sharkwing")]
        public bool RequiresSharkwing { get; private set; }
    }
}
