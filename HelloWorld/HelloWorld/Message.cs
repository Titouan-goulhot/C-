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
        private IDateTime dt;
        public string HelloMessage {get; set;}

        public int Hour = DateTime.Now.Hour;

        public int Matin { get; set; }

        public int ApresMidi { get; set; }

        public int Soir { get; set; }
       

        public string UserName = Environment.UserName;


        //Constructor 

        public Message()
            :this(9, 13, 18, new MyDateTime())
        {
        
        }
        public Message(int matin, int apresMidi, int soir, IDateTime dateTime)
        {
            dt = dateTime;
            Matin = matin;
            ApresMidi = apresMidi;
            Soir = soir;
        }

         public Message (IDateTime dateTime)
            :this(9,13,18, dateTime)
        {
        }


        //Méthode 

        public void MessageOfTheDay()
        {
            //Affichage le matin en semaine
            if (dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && dt.Hour >= Matin && dt.Hour < ApresMidi)
            {
               HelloMessage = "Bonjour ! " + UserName;
            }

            //Affichage l'après-midi en semaine
            else if (dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && (dt.Hour >= ApresMidi && dt.Hour <= Soir))
            {
               HelloMessage = "Bon Après-Midi ! " + UserName;
            }

            //Affichage du soir en semaine
            else if (dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday && (dt.Hour >= Soir || dt.Hour < Matin)) 
            {
               HelloMessage = "Bonsoir ! " + UserName;
            }

            //Affichage du Week-End le vendredi après Soir && Lundi avant Matin 
            else if (dt.DayOfWeek == DayOfWeek.Friday && (dt.Hour > Soir) || dt.DayOfWeek == DayOfWeek.Monday && (dt.Hour < Matin)) 
            {
               HelloMessage = "Bon Week-End ! " + UserName;

            } //Affichage du Week-End le Samedi && Dimanche
            else if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
               HelloMessage = "Bon Week-End ! " + UserName;
            };
        }
    }


}
