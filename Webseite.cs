using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Muster1
{
    internal class Webseite
    {
        private string Kennung;
        private string content;
        public Webseite(string kennung)
        {
            this.Kennung = kennung;
        }
        public string GetKennung()
        {
            return this.Kennung;
        }
        public void SetContent(string content)
        {
            this.content = content; 
        }
        public string GetContent()
        {
            return this.content; 
        }
    }
}
