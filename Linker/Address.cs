using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Linker
{
    public class Address
    {
        [JsonProperty("id")]
        public int Id { set; get; }

        [JsonProperty("name")]
        public string Name { set; get; }

        [JsonProperty("url")]
        public string Url { set; get; }

        [JsonProperty("description")]
        public string Description{ set; get; }
    }
}
