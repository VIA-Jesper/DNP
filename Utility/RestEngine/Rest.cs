using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestEngine
{
    /// <summary>
    /// Rest engine to pull RESTful APIs
    /// </summary>
    public class RestGetMethod : IRestEngine
    {
        public async Task<string> Request(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    // response body
                    return await response.Content.ReadAsStringAsync();
                }
            }

            return null;
        }

    }
}
