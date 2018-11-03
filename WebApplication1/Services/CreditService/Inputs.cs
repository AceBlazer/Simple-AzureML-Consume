using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class Inputs
    {
        public IList<CreditProfile> CreditProfile { get; }

        public Inputs(CreditProfile creditProfile)
        {
            CreditProfile = new List<CreditProfile>() { creditProfile };
        }
    }
}
