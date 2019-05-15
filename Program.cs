using System;

namespace TCSharp
{
    class App
    {
        public void Run()
        {
            bool done = false;
            while (!done)
            {
                Console.Write(">");
                string command = Console.ReadLine();
                if (command.ToLower() == "quit") 
                {
                    done = true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmptyClass ec = new EmptyClass();
            Square board = new Square();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi there again!");
            ec.doSomething();
            board.doSomething();

            App app = new App();
            app.Run();
        }
    }
}
