using System;

namespace HomeworkChat

{
    internal class Program
    {
        public void Client()
        {

        }
        static void Main(string[] args)
        {
            

            if (args.Length == 0)
            {
                Chat.Server();
            }
            else
            {
                Chat.Client(args[0]);
            }
        }
    }
}