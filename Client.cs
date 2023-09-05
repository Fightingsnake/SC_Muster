using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Muster1
{
    internal class Client
    {
        private Webseite startseite;
        public void ServerKontaktieren(Server empfaenger)
        {
            if (empfaenger.ClientAntworten(this))
                Console.WriteLine("Perfekt!");
            else
                Console.WriteLine("Something gone wrong :(");
        }
        public void SetStartseite(Webseite seite)
        {
            this.startseite = seite;
        }
        public Webseite GetStartseite()
        {
            return this.startseite;
        }
        public void WebseiteDarstellen(Webseite SeiteZumAnzeigen)
        {
            Console.WriteLine("\n\nTitel:");
            Console.WriteLine(SeiteZumAnzeigen.GetKennung());
            Console.WriteLine("\nInhalt:");
            Console.WriteLine(SeiteZumAnzeigen.GetContent());
        }
    }
}
