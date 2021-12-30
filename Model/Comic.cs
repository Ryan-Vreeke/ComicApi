using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Comic
    {
        [JsonProperty]
        private string id;
        [JsonProperty]
        private string type;
        [JsonProperty]
        private Attributes attributes;
        [JsonProperty]
        private List<Relationship> relationships;        

        public Attributes att { get { return attributes; } set { attributes = value; } }

        public override string ToString()
        {
            return "Name: " + attributes.Title.ToString() + "Links: " + attributes.Link.ToString();
        }
    }
}
