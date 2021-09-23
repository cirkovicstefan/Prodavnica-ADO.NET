using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class StavkaFiskalnogRacuna
    {
        int idStavke;
        string idArtikla;
        double kolicina;

        public StavkaFiskalnogRacuna(int idStavke, string idArtikla, int kolicina)
        {
            this.idStavke = idStavke;
            this.idArtikla = idArtikla;
            this.kolicina = kolicina;
        }

        public StavkaFiskalnogRacuna() : this(-1,"",0) { }

        public StavkaFiskalnogRacuna(string idArtikla, double kolicina)
        {
            this.idStavke = -1;
            this.idArtikla = idArtikla;
            this.kolicina = kolicina;
        }

        [DataMember]
        public int IdStavke { get => idStavke; set => idStavke = value; }
        [DataMember]
        public string IdArtikla { get => idArtikla; set => idArtikla = value; }
        [DataMember]
        public double Kolicina { get => kolicina; set => kolicina = value; }
    }
}
