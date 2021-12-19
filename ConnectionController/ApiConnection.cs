using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Model;

namespace Connection
{
    class ApiConnection
    {
        HttpClient client = new HttpClient();
        Collection collection;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Getting Json!!");
            ApiConnection conn = new ApiConnection();
            await conn.GetComics();
            conn.Process();

        }

        private void Process()
        {
            Console.WriteLine(collection.ToString());

            foreach (Comic c in collection.comics)
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine(c.att.Title);

            }
        }

        private async Task GetComics()
        {
            string response = await client.GetStringAsync("https://api.mangadex.org/manga");


            collection = JsonConvert.DeserializeObject<Collection>(response);


            //Console.WriteLine(response);
        }

    }
}
