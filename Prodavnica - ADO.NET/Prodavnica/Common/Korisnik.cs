using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public enum Uloga {
        [EnumMember] Administrator, [EnumMember] Kasir, [EnumMember] None
    }

    [DataContract]
    public class Korisnik
    {
        string korisnickoIme;
        string lozinka;
        string imeIPrezime;
        Uloga uloga;

        public Korisnik(string korisnickoIme, string lozinka, string imeIPrezime, Uloga uloga)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.imeIPrezime = imeIPrezime;
            this.uloga = uloga;
        }

        public Korisnik() : this("","","",Uloga.None) { }

        [DataMember]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [DataMember]
        public string Lozinka { get => lozinka; set => lozinka = value; }
        [DataMember]
        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        [DataMember]
        public Uloga Uloga { get => uloga; set => uloga = value; }
    }
}
