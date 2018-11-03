using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class Results
    {
        [JsonProperty("ApprovalStatus")]
        public IList<ApprovalStatus> ApprovalStatus { get; set; }
    }
}
