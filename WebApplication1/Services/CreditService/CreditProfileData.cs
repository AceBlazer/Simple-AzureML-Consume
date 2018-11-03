using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class CreditProfileData
    {
        public CreditProfileData(CreditProfile creditProfile)
        {
            Inputs = new Inputs(creditProfile);
        }

        public Inputs Inputs { get; }

        public Dictionary<string, string> GlobalParameters => new Dictionary<string, string>() { };
    }
   
}
