using System.Collections.Generic;
using Newtonsoft.Json;

namespace EosRio.HyperionApi
{
    public class Response4 
    {
        [JsonProperty("query_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double QueryTime { get; set; }
    
        [JsonProperty("last_irreversible_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double LastIrreversibleBlock { get; set; }
    
        [JsonProperty("actions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Actions2> Actions { get; set; }
    }
}