using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolumeWebService.VolumeCalculator;

namespace VolumeWeb.Data
{
    public class VolumeService
    {
        private readonly HttpClient client;
        public VolumeService(IHttpClientFactory http)
        {
            client = http.CreateClient();
        }

        public async Task<VolumeResult> GetCylinderVolume(decimal height, decimal radius)
        {
            var response = await client.GetAsync($"calculate/cylinder?height={height}&radius={radius}");
            var test= JsonSerializer.Deserialize<VolumeResult>(await response.Content.ReadAsStringAsync());
            return JsonSerializer.Deserialize<VolumeResult>(await response.Content.ReadAsStringAsync());
        }

        public async Task<VolumeResult> GetConeVolume(decimal height, decimal radius)
        {
            var response = await client.GetAsync($"calculate/cone?height={height}&radius={radius}");

            return JsonSerializer.Deserialize<VolumeResult>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<VolumeResult>> GetCalculations()
        {
            var response = await client.GetAsync($"calculate");
            return JsonSerializer.Deserialize<List<VolumeResult>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<VolumeResult> PostCalculation(string type, decimal height, decimal radius)
        {
            var response = await client.PostAsync($"calculate/{type}?height={height}&radius={radius}", new StringContent("", Encoding.UTF8, "application/json"));
            return JsonSerializer.Deserialize<VolumeResult>(await response.Content.ReadAsStringAsync());
        }



    }
}
