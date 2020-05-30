using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    /// <summary>
    /// Nightwave Challenge Struct
    /// </summary>
    public struct NightwaveChallenge
    {
        /// <summary>
        /// Challenge Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Challenge Description
        /// </summary>
        [JsonProperty("desc")]
        public string Description { get; private set; }

        /// <summary>
        /// Challenge Expiration Timestamp
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// Amount of reputation rewarded on completion 
        /// </summary>
        [JsonProperty("reputation")]
        public int Reputation { get; private set; }

        /// <summary>
        /// Challenge title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// If the challenge is a daily challenge
        /// </summary>
        [JsonProperty("isDaily")]
        public bool IsDaily { get; private set; }

        /// <summary>
        /// If the challenge is an elite challenge
        /// </summary>
        [JsonProperty("isElite")]
        public bool IsElite { get; private set; }
    }
}
