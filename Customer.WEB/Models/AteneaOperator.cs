using Newtonsoft.Json;

namespace Customer.WEB.Models
{
    public class AteneaOperator
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public int Country { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
