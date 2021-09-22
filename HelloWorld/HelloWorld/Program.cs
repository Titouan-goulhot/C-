using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            Message message = new Message();

                message.MessageOfTheDay();

            Console.WriteLine("Write 'exit' to exit or press 'Enter' to restart the program ");
            while (Console.ReadLine() != "exit") {

                    
                    Console.WriteLine(message.HelloMessage);
                
            }

           


        }

       
    }
    
}
