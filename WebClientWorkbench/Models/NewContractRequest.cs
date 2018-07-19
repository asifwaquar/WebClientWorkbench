using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebClientWorkbench.Models
{
    public class WorkflowActionInput
    {
        [JsonProperty("workflowActionParameters")]
        public List<ContractActionParameter> WorkflowActionParameters = new List<ContractActionParameter>();

        [JsonProperty("workflowFunctionID")]
        public int WorkflowFunctionID { get; set; }
    }

    public class ContractActionParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

    }


}
