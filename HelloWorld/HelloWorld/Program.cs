using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Message message = new Message();

           
            Console.WriteLine(message.MessageOfTheDay());

            Console.ReadLine();

        }

       
    }
    
}
