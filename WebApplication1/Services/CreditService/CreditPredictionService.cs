using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; 
using System.Net.Http.Headers;  
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using WebApplication1.Services.CreditService;

namespace azureMLtest.Services.CreditService
{
    public class CreditPredictionService
    {
        public async Task<string> PreApproveCredit()
        {
            using (var client = new HttpClient())
            {


                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "CreditProfile",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Loan Amount", "12232"
                                            },
                                            {
                                                "Term", "Short Term"
                                            },
                                            {
                                                "Credit Score", "728"
                                            },
                                            {
                                                "Years in Current Job", "< 1 year"
                                            },
                                            {
                                                "Home Ownership", "Rent"
                                            },
                                            {
                                                "Annual Income", "46643"
                                            },
                                            {
                                                "Purpose", "Debt Consolidation"
                                            },
                                            {
                                                "Monthly Debt", "777.39"
                                            },
                                            {
                                                "Years of Credit History", "18"
                                            },
                                            {
                                                "Months Since Last Delinquent", "10"
                                            },
                                            {
                                                "Number of Open Accounts", "12"
                                            },
                                            {
                                                "Number of Credit Problems", "0"
                                            },
                                            {
                                                "Current Credit Balance", "6762"
                                            },
                                            {
                                                "Maximum Open Credit", "7946"
                                            },
                                            {
                                                "Bankruptcies", "0"
                                            },
                                            {
                                                "Tax Liens", "0"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };


                const string apiKey = "B3VvxJGBPCY00AI2/lCn2vXUuQBb+e4xDb15m5XLUShPLcX7wyANtnsXKa3ax8vgrxEnDric+eJjGfjj+A1UGA=="; // Replace this with the API key for the web service

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/92777bc033bd46dfa8ff60adddc2cd64/services/765d64adb6c04f50941625850d3451c5/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client
                        .PostAsync("", new StringContent(JsonConvert.SerializeObject(scoreRequest), Encoding.UTF8, "application/json"))
                        .ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    return string.Format("The request failed with status code: {0}", response.StatusCode);
                }
            }
        }
    }
}
