using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }
        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }

    }
}
