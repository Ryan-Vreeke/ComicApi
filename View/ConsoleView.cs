using System;
using Connection;
using System.Threading.Tasks;
using Model;

namespace View
{

    class ConsoleView
    {
        static async Task Main(string[] args)
        {
            ApiConnection conn = new ApiConnection();
            string command;
            bool quit = false;
            while (!quit)
            {
                System.Console.Write("Enter Command:");
                command = Console.ReadLine();
                switch (command)
                {
                    case "/manga"://Gets 10 manga
                        await conn.GetComics();
                        conn.Process();
                        break;
                    case "/select":
                        Console.Write("Enter Manga number: ");
                        int mangaId = int.Parse(Console.ReadLine());

                        await conn.GetChapters(mangaId);

                        break;
                    case "/quit":
                        quit = true;
                        break;
                }
            }

        }
    }
}
