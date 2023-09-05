using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Muster1
{
    internal class Server
    {
        private List<Webseite> Seiten = new List<Webseite>();
        private string Adresse;
        private Webseite Fehladresse = new Webseite("Fehlerhafte Adresse!");
        public void AddWebseite(Webseite webseite)
        {
            this.Seiten.Add(webseite);
        }
        public Webseite CheckWebseite(string kennung)
        {
            foreach (Webseite akt in this.Seiten)
                if (akt.GetKennung() == kennung)
                    return akt;
            return this.Fehladresse;
        }
        public bool ClientAntworten(Client empfaenger)
        {
            return true;
        }
    }
}
