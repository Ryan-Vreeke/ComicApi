using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Model;

namespace Connection
{
    public class ApiConnection
    {
        HttpClient client = new HttpClient();
        Collection collection;

        public static void Main(string[] args)
        {

        }
        public void Process()
        {
            Console.WriteLine(collection.ToString());

            foreach (Comic c in collection.comics)
            {
                Console.WriteLine(collection.comics.IndexOf(c) + ": " + c.ToString());
            }
        }

        public async Task GetChapters(int id)
        {
            string response = await client.GetStringAsync("https://api.mangadex.org/manga/" + collection.comics[id].ID + "/aggregate");
            ChapterCollection chCol = JsonConvert.DeserializeObject<ChapterCollection>(response);
        }

        public async Task GetComics()
        {
            string response = await client.GetStringAsync("https://api.mangadex.org/manga");

            collection = JsonConvert.DeserializeObject<Collection>(response);


            //Console.WriteLine(response);
        }

    }
}
