using System;
using Newtonsoft.Json;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Title
    {
        [JsonProperty]
        private string en;

        public override string ToString()
        {
            return en;
        }
    }
}