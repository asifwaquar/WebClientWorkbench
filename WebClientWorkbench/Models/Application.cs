using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQC_WebClient_Workbench.Models
{
    public class Application
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        //[JsonProperty("applicationType")]
        //public string ApplicationType { get; set; }

        [JsonProperty("createdByUserId")]
        public long CreatedByUserId { get; set; }

        [JsonProperty("createdDtTm")]
        public System.DateTimeOffset CreatedDtTm { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("applicationRoles")]
        public List<ApplicationRole> ApplicationRoles = new List<ApplicationRole>();

        //[JsonProperty("workflows")]
        //public List<Workflow> Workflows = new List<Workflow>();
    }
}
