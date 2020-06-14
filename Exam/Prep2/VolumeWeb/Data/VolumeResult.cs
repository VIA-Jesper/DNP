using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("height")]
        public decimal Height { get; set; }
        [JsonPropertyName("radius")]
        public decimal Radius { get; set; }
        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
    }
}
