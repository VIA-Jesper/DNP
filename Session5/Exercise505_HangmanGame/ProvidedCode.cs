using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercise505_HangmanGame
{
    class ProvidedCode
    {

        HttpClient client = new HttpClient();
        public async Task<string> GetWord()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Report");
            var streamTask = client.GetStringAsync("https://random-word-api.herokuapp.com/word?number=1");
            string result = await streamTask;
            return result;

        }

    }
}
