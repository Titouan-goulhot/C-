using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void MessageOfTheDayTest()
        {


            //En semaine le Soir
            Message message = new Message( new FakeMyDateTime(DayOfWeek.Monday, 19));

            message.MessageOfTheDay();

            Assert.AreEqual(message.HelloMessage, "Bonsoir ! titouan.goulhot");


            // En semaine l'après-midi
            Message message1 = new Message(new FakeMyDateTime(DayOfWeek.Monday, 15));

            message1.MessageOfTheDay();

            Assert.AreEqual(message1.HelloMessage, "Bon Après-Midi ! titouan.goulhot");


            // En Week-End
            Message message2 = new Message(new FakeMyDateTime(DayOfWeek.Sunday, 6));

            message2.MessageOfTheDay();

            Assert.AreEqual(message2.HelloMessage, "Bon Week-End ! titouan.goulhot");

            //Le Lundi avant "le Matin"
            /*
            Message message3 = new Message(new FakeMyDateTime(DayOfWeek.Monday, 6));

            message3.MessageOfTheDay();

            Assert.AreEqual(message3.HelloMessage, "Bon Week-End ! titouan.goulhot");
            */

        }
    }
}