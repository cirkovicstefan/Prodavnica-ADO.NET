using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class FiskalniRacun
    {
        int idRacuna;
        DateTime datumiVreme;
        string imeiPrezime;
        double iznosRacuna;
        List<StavkaFiskalnogRacuna> listaStavki;

        public FiskalniRacun() : this(new DateTime(),"",0) { }

        public FiskalniRacun(int idRacuna, DateTime datumiVreme, string imeiPrezime, double iznosRacuna)
        {
            this.idRacuna = idRacuna;
            this.datumiVreme = datumiVreme;
            this.imeiPrezime = imeiPrezime;
            this.iznosRacuna = iznosRacuna;
            listaStavki = new List<StavkaFiskalnogRacuna>();
        }

        public FiskalniRacun(DateTime datumiVreme, string imeiPrezime, double iznosRacuna)
        {
            this.idRacuna = -1;
            this.datumiVreme = datumiVreme;
            this.imeiPrezime = imeiPrezime;
            this.iznosRacuna = iznosRacuna;
            listaStavki = new List<StavkaFiskalnogRacuna>();
        }

        [DataMember]
        public int IdRacuna { get => idRacuna; set => idRacuna = value; }
        [DataMember]
        public DateTime DatumiVreme { get => datumiVreme; set => datumiVreme = value; }
        [DataMember]
        public string ImeiPrezime { get => imeiPrezime; set => imeiPrezime = value; }
        [DataMember]
        public double IznosRacuna { get => iznosRacuna; set => iznosRacuna = value; }
        [DataMember]
        public List<StavkaFiskalnogRacuna> ListaStavki { get => listaStavki; set => listaStavki = value; }
    }
}
