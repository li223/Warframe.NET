using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WorldState.Data.Enums;
using WorldState.Data.Models;
using WorldState.Objects;

namespace WorldState
{
    public class WarframeClient
    {
        public delegate Task ClientErroredArgs(Error error);

        /// <summary>
        /// Invoked when an error occurs during a request
        /// </summary>
        public event ClientErroredArgs ClientErrored;

        private const string BASEURL = "api.warframestat.us";

        private Platform DefaultPlatform { get; set; } = Platform.PC;

        private HttpClient HttpClient { get; set; }

        /// <summary>
        /// Basic ctor
        /// </summary>
        public WarframeClient() => this.HttpClient = new HttpClient();

        /// <summary>
        /// Ctor that allows you to specify the default platform to use across all requests
        /// </summary>
        /// <param name="platform">Platform to set as default</param>
        public WarframeClient(Platform platform)
        {
            this.HttpClient = new HttpClient();
            this.DefaultPlatform = platform;
        }

        /// <summary>
        /// Ctor that allows you to specify the language to return text in
        /// </summary>
        /// <param name="language"></param>
        public WarframeClient(Locale language)
        {
            this.HttpClient = new HttpClient();
            this.HttpClient.DefaultRequestHeaders.Add("Accept-Language", language.ToString().ToLower());
        }

        /// <summary>
        /// Ctor that allows you to specify the default platform to use across all requests as well as the language
        /// </summary>
        /// <param name="platform">Platform to set as default</param>
        public WarframeClient(Platform platform, Locale language)
        {
            this.HttpClient = new HttpClient();
            this.DefaultPlatform = platform;
            this.HttpClient.DefaultRequestHeaders.Add("Accept-Language", language.ToString().ToLower());
        }

        /// <summary>
        /// Get the world state for the current platform
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>WorldState on success, null on failure</returns>
        public async Task<Data.Models.WorldState> GetWorldStateAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if(response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<Data.Models.WorldState>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get alert data
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>IEnumerable of Alert on success, null on failure</returns>
        public async Task<IEnumerable<Alert>> GetAlertsAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/alerts").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<IEnumerable<Alert>>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get the arbitration for the current platform
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>Atribution on success, null on failure</returns>
        [Obsolete("Request is considered unstable")]
        public async Task<Arbitration> GetArbitrationAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/arbitration").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<Arbitration>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get news data
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>IEnumerable of News on success, null on failure</returns>
        public async Task<IEnumerable<News>> GetNewsAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/news").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<IEnumerable<News>>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get cetus cycle data
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>CetusCycle on success, null on failure</returns>
        public async Task<CetusCycle> GetCetusCycleAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/cetusCycle").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<CetusCycle>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get earth cycle data
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>EarthCycle on success, null on failure</returns>
        public async Task<EarthCycle> GetEarthCycleAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/earthCycle").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<EarthCycle>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get the current conclave challenges
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>IEnumerable of ConclaveChallenge on success, null on failure</returns>
        public async Task<IEnumerable<ConclaveChallenge>> GetConclaveChallengesAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/conclaveChallenges").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<IEnumerable<ConclaveChallenge>>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        /// <summary>
        /// Get the current construction progress
        /// </summary>
        /// <param name="platform">Platform to get data for</param>
        /// <returns>CetusCycle on success, null on failure</returns>
        public async Task<ConstructionProgress> GetConstructionProgressAsync(Platform? platform = null)
        {
            var response = await this.HttpClient.GetAsync($"{BASEURL}/{this.ConvertPlatform(platform)}/constructionProgress").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<ConstructionProgress>(content);
                return data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<Error>(content);
                this.ClientErrored?.Invoke(error);
                return null;
            }
        }

        private string ConvertPlatform(Platform? platform)
        {
            if (platform == null) platform = this.DefaultPlatform;
            return (platform == Platform.Switch) ? "swi" : platform.ToString().ToLower();
        }
    }
}
