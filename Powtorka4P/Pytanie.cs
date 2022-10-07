using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorka4P
{
    public class Pytanie // ♥
    {
        public int nrPytania { get; set; }
        public string trescPytania { get; set; }
        public List<string> odpowiedzi { get; set; }
        public int odpowiedzOK { get; set; }

        public Pytanie(int nrPytania, string trescPytania, List<string> odpowiedzi, int odpowiedzOK)
        {
            this.nrPytania = nrPytania;
            this.trescPytania = trescPytania;
            this.odpowiedzi = odpowiedzi;
            this.odpowiedzOK = odpowiedzOK;
        }
    }

}
