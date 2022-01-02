using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Volume
    {
        [JsonProperty]
        string volume;
        [JsonProperty]
        int count;
        [JsonProperty]
        List<Chapter> chapters;

    }
}