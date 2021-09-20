using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        // Properties 
        private DateTime dt = DateTime.Now;
        private string helloMessage;



        //Constructor 

        public Message()
        {

        }
        public Message(DateTime dt, string helloMessage)
        {
        
        }




        // Getter & Setter
        public DateTime Dt
        {
            get { return dt; }
        }

        public string HelloMessage
        {
            get { return helloMessage; }
        }




        //Méthode 

        public string MessageOfTheDay()
        {
            //Affichage le matin en semaine
            if(dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && dt.Hour >= 9 && dt.Hour <= 13)
            {
                return("Bonjour ! " + Environment.UserName);
            }

            //Affichage l'après-midi en semaine
            else if(dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && dt.Hour >= 13 && dt.Hour <= 18)
            {
               return ("Bon Après-Midi ! " + Environment.UserName);
            }

            //Affichage du soir en semaine
           else if (dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && dt.Hour >= 18 && dt.Hour <= 9)
            {
                return ("Bonsoir ! " + Environment.UserName);
            }


            //Affichage du Week-End le vendredi après 18h && Lundi avant 9h
            else if(dt.DayOfWeek == DayOfWeek.Friday && dt.Hour >= 18 && dt.DayOfWeek == DayOfWeek.Monday && dt.Hour <= 9)
            {
               return ("Bon Week-End ! " + Environment.UserName);

            } //Affichage du Week-End le Samedi && Dimanche
            else if(dt.DayOfWeek == DayOfWeek.Saturday && dt.DayOfWeek == DayOfWeek.Sunday)
            {
               return ("Bon Week-End ! " + Environment.UserName);
            };

            return MessageOfTheDay();
        }
    }

        
}
