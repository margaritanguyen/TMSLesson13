﻿using System.Text.Json.Serialization;

namespace TMSLesson13
{
    public class Squad
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }

        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }

        [JsonPropertyName("formed")]
        public int Formed { get; set; }

        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("members")]
        public SquadMember[] Members { get; set; }
    }
}
