using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Muster1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server x = new Server();
            
            Webseite a = new Webseite("Testseite");
            a.SetContent("Test");
            x.AddWebseite(a);
            x.CheckWebseite("Testseite");
            x.CheckWebseite("test");
            Webseite b = new Webseite("impressum");
            b.SetContent("inhaber: ich\nadresse: hab ich\nplz: anwesend");
            Webseite c = new Webseite("wir koennen es!");
            c.SetContent("Welch koestlicher inhalt");
            x.AddWebseite(b);
            x.AddWebseite(c);
            Client Ferhat = new Client();
            Ferhat.ServerKontaktieren(x);
            Ferhat.SetStartseite(a);
            Ferhat.WebseiteDarstellen(a);
            Ferhat.WebseiteDarstellen(b);
            
        }
    }
}
