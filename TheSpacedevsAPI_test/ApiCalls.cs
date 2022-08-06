using TheSpacedevsAPI_test.Responses;

namespace TheSpacedevsAPI_test
{
    internal class ApiCalls
    {
        public async Task<AgenciesResponse> GetAgenciesList()
        {
            var count = 0;
            var res = new AgenciesResponse();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiEndpoints.agenciesList);

                do
                {
                    HttpResponseMessage response;
                    if (res.Count > 0)
                    {
                        response = await client.GetAsync(res.Next);
                    }
                    else
                    {
                        response = await client.GetAsync(ApiEndpoints.agenciesList);
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();

                        if (res.Count > 0)
                        {
                            var intermidiateResult = Newtonsoft.Json.JsonConvert.DeserializeObject<AgenciesResponse>(data);
                            res.Results.AddRange(intermidiateResult.Results);
                            res.Next = intermidiateResult.Next;
                        }
                        else
                        {
                            res = Newtonsoft.Json.JsonConvert.DeserializeObject<AgenciesResponse>(data);
                        }

                        count = res.Results.Count;
                        Console.WriteLine(count);
                    }
                }
                while (res.Count > count);

            }
            return res;
        }
    }
}
