using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Home13
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class Ingredient
    {
        [JsonProperty]
        public string Name { get; set; } = string.Empty;
        [JsonProperty]
        public double Price { get; set; } = 0d;
        [JsonProperty("Energy")]
        public double EnergyCost { get; set; } = 0d;
        [JsonProperty]
        public string Manufacturer { get; set; } = string.Empty;
    }
}
