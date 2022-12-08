﻿using System.Collections.Generic;
using HyperionApiClient.Core.Models;
using Newtonsoft.Json;

namespace HyperionApiClient.Core.Responses
{
    public class GetTableByScopeResponse
    {
        [JsonProperty("rows")]
        public List<TableByScopeRow> Rows { get; set; }

        [JsonProperty("more")]
        public string More { get; set; }
    }
}