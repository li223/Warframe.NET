using Newtonsoft.Json;

namespace WorldState.Objects
{
    /// <summary>
    /// Object for an api error response
    /// </summary>
    public struct Error
    {
        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("error")]
        public string Message { get; private set; }

        /// <summary>
        /// Status Code
        /// </summary>
        [JsonProperty("code")]
        public int StatusCode { get; private set; }
    }
}
