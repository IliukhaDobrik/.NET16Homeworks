using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Home13
{
    //[JsonObject(MemberSerialization.OptIn)]
    internal class Diet
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        [JsonIgnore]
        public string Code { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
