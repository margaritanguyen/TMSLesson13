using System.Text.Json.Serialization;

namespace TMSLesson13
{
    public class SquadMember
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }

        [JsonPropertyName("powers")]
        public string[] Powers { get; set; }
    }
}
