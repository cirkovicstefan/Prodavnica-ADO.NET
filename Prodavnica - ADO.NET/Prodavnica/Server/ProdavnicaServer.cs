using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Server
{
    class ProdavnicaServer : IProdavnica
    {
        public List<Artikal> ArtikliPoOpseguCene(double cenaOD, double cenaDO)
        {
            return KonekcijaSaBazom.SelectArtikli(cenaOD, cenaDO);
        }

        public void DodajArtikal(Artikal artikal)
        {
            string naredba = String.Format("INSERT into Artikli values('{0}','{1}','{2}',{3},{4})",
                artikal.IdArtikla, artikal.Naziv, artikal.Mera, artikal.Kolicina,artikal.Cena);
            KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }

        public void DodajKorisnika(Korisnik korisnik)
        {
            string naredba = String.Format("INSERT into Korisnici values('{0}','{1}','{2}','{3}')",
                  korisnik.KorisnickoIme, korisnik.Lozinka, korisnik.Uloga, korisnik.ImeIPrezime);
            KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }

        public void DodajRacun(FiskalniRacun racun)
        {
            string naredba = String.Format("INSERT into FiskalniRacun values('{0}','{1}',{2})",
                  racun.DatumiVreme, racun.ImeiPrezime, racun.IznosRacuna);
            KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);

            int idFIskalnog = (int) KonekcijaSaBazom.ExecuteScalarSqlCommand("SELECT idFIskalnog from FiskalniRacun where DatumIVreme ='"+racun.DatumiVreme+"'");

            foreach(StavkaFiskalnogRacuna stavka in racun.ListaStavki)
            {
                string naredba2 = String.Format("INSERT into Stavke values({0},'{1}',{2})",
                 idFIskalnog,stavka.IdArtikla , stavka.Kolicina);
                KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba2);
            }
              
        }

        public string ImeIPrezime(string korisnickoIme)
        {
            string imeIPrezime = (string)KonekcijaSaBazom.ExecuteScalarSqlCommand("Select imeIPrezime from Korisnici where korisnickoIme ='" + korisnickoIme + "'");
            return imeIPrezime;
        }

        public void IzmeniArtikal(Artikal artikal)
        {
            string naredba = String.Format("UPDATE Artikli set Naziv = '{0}', JedinicaMere = '{1}', Kolicina = {2}, Cena = {3}" +
                " where idArtikla = '{4}'",artikal.Naziv, artikal.Mera,artikal.Kolicina, artikal.Cena, artikal.IdArtikla);
            KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }

        public void IzmeniKorisnika(Korisnik korisnik)
        {
            string naredba = String.Format("UPDATE Korisnici set Lozinka = '{0}', Uloga = '{1}', ImeIPrezime = '{2}'" +
                 " where korisnickoIme = '{3}'", korisnik.Lozinka, korisnik.Uloga, korisnik.ImeIPrezime, korisnik.KorisnickoIme);
            KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }

        public Uloga LogIn(string korisnickoIme, string lozinka)
        {
            string uloga = (string) KonekcijaSaBazom.ExecuteScalarSqlCommand("Select uloga from Korisnici where korisnickoIme = '" + korisnickoIme + "' and lozinka = '" + lozinka + "'");
            if (uloga == null)
                return Uloga.None;
            else
                return (Uloga)Enum.Parse(typeof(Uloga), uloga);
            
        }

        public bool ObrisiArtikal(string idArtikla)
        {
            string naredba = "DELETE from Artikli where idArtikla ='"+ idArtikla +"'";
            return KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }

        public bool ObrisiKorisnika(string korisnickoIme)
        {
            string naredba = "DELETE from Korisnici where korisnickoIme ='" + korisnickoIme + "'";
            return KonekcijaSaBazom.ExecuteNonQuerySqlCommand(naredba);
        }


        public List<Artikal> SviArtikli()
        {
            return KonekcijaSaBazom.SelectArtikli();
        }

        public List<Korisnik> SviKorisnici()
        {
            return KonekcijaSaBazom.SelectKorisnici();
        }

        public List<FiskalniRacun> SviRacuni()
        {
            return KonekcijaSaBazom.SelectRacuni();
        }

        public List<FiskalniRacun> SviRacuniKorisnika(string imeIPrezime)
        {            
            return KonekcijaSaBazom.SelectRacuni(imeIPrezime);
        }

        public List<FiskalniRacun> SviRacuniPoDatumu(DateTime datum)
        {            
            return KonekcijaSaBazom.SelectRacuni(datum);
        }
    }
}
