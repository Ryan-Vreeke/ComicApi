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
                    case "/manga":
                        await conn.GetComics();
                        conn.Process();
                        break;
                    case "/quit":
                        quit = true;
                        break;
                }
            }

        }
    }
}
