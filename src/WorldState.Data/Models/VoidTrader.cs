using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WorldState.Data.Models
{
    /// <summary>
    /// Void Trader object
    /// </summary>
    public class VoidTrader
    {
        /// <summary>
        /// Trader Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Timestamp of Trader Activation
        /// </summary>
        [JsonProperty("activation")]
        public DateTime Activation { get; private set; }

        /// <summary>
        /// Timestamp of Trader Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// Name of the Void Trader
        /// </summary>
        [JsonProperty("character")]
        public string Character { get; private set; }

        /// <summary>
        /// Where the trader is or is going to be
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }

        /// <summary>
        /// The trader's current inventory
        /// </summary>
        [JsonProperty("inventory")]
        public IEnumerable<VoidTraderItem> Inventory { get; private set; }

        /// <summary>
        /// Assigned Id
        /// </summary>
        [JsonProperty("psId")]
        public string PsId { get; private set; }

        /// <summary>
        /// If the trader is currently active
        /// </summary>
        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Returns how long until the trader next arrives in human readable format
        /// </summary>
        [JsonProperty("startString")]
        public string StartString { get; private set; }

        /// <summary>
        /// Returns how long until the trader leaves in human readable format
        /// </summary>
        [JsonProperty("endString")]
        public string EndString { get; private set; }

    }
}
