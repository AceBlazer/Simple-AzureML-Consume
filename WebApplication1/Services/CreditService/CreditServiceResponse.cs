using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class CreditServiceResponse
    {
        [JsonProperty("Results")]
        public Results Results { get; set; }

        public ApprovalStatus GetStatus() => Results.ApprovalStatus.First();
    }
}
