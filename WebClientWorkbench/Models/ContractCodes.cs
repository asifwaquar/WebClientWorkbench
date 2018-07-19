using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace IQC_WebClient_Workbench.Models
{
	public class ContractCodesReturnType
    {
        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

		[JsonProperty("contractCodes")]
		public List<ContractCodes> ContractCodes = new List<ContractCodes>();
    }

    public class ContractCodes
    {
		[JsonProperty("contractCodeID")]
        public long ContractCodeId { get; set; }

		[JsonProperty("ledgerID")]
        public long LedgerId { get; set; }      

		[JsonProperty("createdByUserId")]
        public long CreatedByUserId { get; set; }

        [JsonProperty("createdDtTm")]
        public DateTimeOffset CreatedDtTm { get; set; }
    }
}
