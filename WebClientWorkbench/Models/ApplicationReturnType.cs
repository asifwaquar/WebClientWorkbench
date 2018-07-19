using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQC_WebClient_Workbench.Models
{
    public class ApplicationReturnType
    {
        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("applications")]
        public List<Application> Applications = new List<Application>();
    }
}
