using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class ApprovalStatus
    {
        [JsonProperty("IsApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("Scored Probabilities")]
        public float Probability { get; set; }
    }
}
