using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class KlasseRum
    {
        private string _KlasseNavn;

        private List<Studerende> _KlasseNavnListe;

        private DateTime _semesterStart;

        public string KlasseNavn
        {
            get { return _KlasseNavn; }
            set
            {
                _KlasseNavn = value;
            }
        }

        public List<Studerende> KlasseNavnListe
        {
            get { return _KlasseNavnListe; }
            set { _KlasseNavnListe = value; }
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

        public KlasseRum()
        {

        }
    }
}
