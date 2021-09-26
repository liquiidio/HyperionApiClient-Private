using Newtonsoft.Json;

namespace EosRio.HyperionApi
{
    public class Producers 
    {
        [JsonProperty("producer_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProducerName { get; set; }
    
        [JsonProperty("block_signing_key", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BlockSigningKey { get; set; }
    
        [JsonProperty("legacy_key", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LegacyKey { get; set; }
    }
}