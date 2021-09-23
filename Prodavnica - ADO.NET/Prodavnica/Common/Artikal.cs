using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public enum JedinicaMere { [EnumMember] kom, [EnumMember] kg}

    [DataContract]
    public class Artikal
    {
        string idArtikla;
        string naziv;
        double kolicina;
        double cena;
        JedinicaMere mera;

        public Artikal(string idArtikla, string naziv, double kolicina, double cena, JedinicaMere mera)
        {
            this.idArtikla = idArtikla;
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.cena = cena;
            this.mera = mera;
        }

        public Artikal()
        {
            this.idArtikla = "";
            this.naziv = "";
            this.kolicina = 0;
            this.cena = 0;
            mera = JedinicaMere.kg;
        }

        [DataMember]
        public string IdArtikla { get => idArtikla; set => idArtikla = value; }
        [DataMember]
        public string Naziv { get => naziv; set => naziv = value; }
        [DataMember]
        public double Kolicina { get => kolicina; set => kolicina = value; }
        [DataMember]
        public double Cena { get => cena; set => cena = value; }
        [DataMember]
        public JedinicaMere Mera { get => mera; set => mera = value; }
    }
}
