using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVPDLL
{
    public class KVPOtletlap
    {
        #region fields
        string sorszam, torzsszam, otletado, otlet, kvpKepviselo;
        DateTime datum;
        #endregion

        #region properties
        public string Sorszam { get => sorszam; set => sorszam = value; }
        public string Torzsszam { get => torzsszam; set => torzsszam = value; }
        public string Otletado { get => otletado; set => otletado = value; }
        public string Otlet { get => otlet; set => otlet = value; }
        public string KvpKepviselo { get => kvpKepviselo; set => kvpKepviselo = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        #endregion

        #region constructors
        public KVPOtletlap(string sorszam, string torzsszam, string otletado, string otlet, string kvpKepviselo, DateTime datum)
        {
            Sorszam = sorszam;
            Torzsszam = torzsszam;
            Otletado = otletado;
            Otlet = otlet;
            KvpKepviselo = kvpKepviselo;
            Datum = datum;
        } 
        #endregion
    }
}
