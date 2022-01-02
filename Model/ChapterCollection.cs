using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChapterCollection
    {
        [JsonProperty]
        private string result;
        [JsonProperty]
        List<Volume> volumes;
    }
}