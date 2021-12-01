using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPublicIpWebAPI.Models
{
    public class SimpleEndpoint
    {
        [JsonPropertyName("ipAddress")]
        public string IPAddress { get; set; }
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}
