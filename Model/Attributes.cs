using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Attributes
    {
        [JsonProperty]
        private Title title;
        public Title Title { get { return title; } }
        [JsonProperty]
        private Title[] altTitles;
        [JsonProperty]
        private Description description;
        [JsonProperty]
        private Links links;
        [JsonProperty]
        private string originalLanguage;
        [JsonProperty]
        private string lastVolume;
        [JsonProperty]
        private string lastChapter;
        [JsonProperty]
        private string publicationDemographic;
        [JsonProperty]
        private string status;
        [JsonProperty]
        private string contentRating;
        [JsonProperty]
        private string state;
        [JsonProperty]
        private string createdAt;
        [JsonProperty]
        private string updatedAt;
        [JsonProperty]
        private int version;
    }
}
