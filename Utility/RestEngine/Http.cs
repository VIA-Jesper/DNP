using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestEngine
{
    public class Http : IRestEngine
    {
        public async Task<string> Request(string url)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C#");

            var content = await client.GetStringAsync(url);
            return content;


        }
    }
}
