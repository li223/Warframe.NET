using Newtonsoft.Json;

namespace WorldState.Data.Models
{
    /// <summary>
    /// Construction Progress Struct
    /// </summary>
    public class ConstructionProgress
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Current fomorian progress
        /// </summary>
        [JsonProperty("fomorianProgress")]
        public double FomorianProgress { get; private set; }

        /// <summary>
        /// Current razorback progress
        /// </summary>
        [JsonProperty("razorbackProgress")]
        public double RazorbackProgress { get; private set; }

        /// <summary>
        /// Current progress of unknown projects
        /// </summary>
        [JsonProperty("unknownProgress")]
        public double UnknownProgress { get; private set; }
    }
}
