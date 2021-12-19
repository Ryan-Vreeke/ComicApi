using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Collection
    {
        [JsonProperty]
        private string result;
        [JsonProperty]
        private string response;
        [JsonProperty]
        private List<Comic> data;
        [JsonProperty]
        private int limit;
        [JsonProperty]
        private int offset;
        [JsonProperty]
        private int total;

        public List<Comic> comics { get { return data; }}

        public Collection()
        {

        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public override string ToString()
        {
            return "result: " + result + "\n" + data.Count;
        }

    }

    
}
