using System;
using Newtonsoft.Json;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Links
    {
        [JsonProperty]
        private string al;
        [JsonProperty]
        private string ap;
        [JsonProperty]
        private string mu;
        [JsonProperty]
        private string raw;

        public override string ToString(){
            return al;
        }

    }
}