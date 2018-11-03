﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.CreditService
{
    public class CreditProfile
    {
        [JsonProperty("Loan Amount")]
        public int LoanAmount { get; set; }

        [JsonProperty("Term")]
        public string Term { get; set; }

        [JsonProperty("Credit Score")]
        public int CreditScore { get; set; }

        [JsonProperty("Years in Current Job")]
        public string YearsInCurrentJob { get; set; }

        [JsonProperty("Home Ownership")]
        public string HomeOwnership { get; set; }

        [JsonProperty("Annual Income")]
        public int AnnualIncome { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Monthly Debt")]
        public double MonthlyDebt { get; set; }

        [JsonProperty("Years of Credit History")]
        public int YearsOfCreditHistory{ get; set; }

        [JsonProperty("Months Since Last Delinquent")]
        public int MonthsSinceLastDelinquent { get; set; }

        [JsonProperty("Number of Open Accounts")]
        public int NumberOfOpenAccounts { get; set; }

        [JsonProperty("Number of Credit Problems")]
        public int NumberOfCreditProblems { get; set; }

        [JsonProperty("Current Credit Balence")]
        public int CurrentCreditBalence { get; set; }

        [JsonProperty("Maximum Open Credit")]
        public int MaximumOpenCredit { get; set; }

        [JsonProperty("Bankruptcies")]
        public int Bankruptcies { get; set; }

        [JsonProperty("Tax Liens")]
        public int TaxLiens { get; set; }

    }
}
