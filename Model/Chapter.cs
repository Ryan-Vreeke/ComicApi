using System;
using Newtonsoft.Json;


namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Chapter
    {
        [JsonProperty]
        string chapter;
        [JsonProperty]
        string id;
        [JsonProperty]
        string[] others;
        [JsonProperty]
        int count;
    }
}