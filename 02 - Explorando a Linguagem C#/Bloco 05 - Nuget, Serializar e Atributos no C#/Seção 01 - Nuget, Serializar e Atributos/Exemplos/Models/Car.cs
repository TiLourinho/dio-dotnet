using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exemplos.Models
{
    public class Car
    {
        public int Id { get; set; }

        [JsonProperty("Car_Name")]
        public string Name { get; set; }

        [JsonProperty("Car_Branch")]
        public string Branch { get; set; }

        [JsonProperty("Release_Year")]
        public int ReleaseYear { get; set; }

        public decimal Price { get; set; }
    }
}