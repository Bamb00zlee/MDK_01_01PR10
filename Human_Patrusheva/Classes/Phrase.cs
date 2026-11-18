using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Patrusheva.Classes
{
    public class Phrase
    {
        public string _Phrase {  get; set; }
        public string Scr {  get; set; }

        public Phrase(string phrase, string scr)
        {
            _Phrase = phrase;
            Scr = scr;

        }
    }
}
