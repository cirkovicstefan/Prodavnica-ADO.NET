using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IProdavnica
    {
        #region CRUD Korisnici

        [OperationContract]
        void DodajKorisnika(Korisnik korisnik);

        [OperationContract]
        bool ObrisiKorisnika(string korisnickoIme);

        [OperationContract]
        List<Korisnik> SviKorisnici();

        [OperationContract]
        Uloga LogIn(string korisnickoIme, string lozinka);

        [OperationContract]
        string ImeIPrezime(string korisnickoIme);

        [OperationContract]
        void IzmeniKorisnika(Korisnik korisnik);

        #endregion

        #region CRUD Artikli

        [OperationContract]
        void DodajArtikal(Artikal artikal);

        [OperationContract]
        bool ObrisiArtikal(string idArtikla);

        [OperationContract]
        void IzmeniArtikal(Artikal artikal);

        [OperationContract]
        List<Artikal> SviArtikli();

        [OperationContract]
        List<Artikal> ArtikliPoOpseguCene(double cenaOD, double cenaDO);

        #endregion

        #region Racuni

        [OperationContract]
        List<FiskalniRacun> SviRacuniKorisnika(string imeIPrezime);

        [OperationContract]
        List<FiskalniRacun> SviRacuniPoDatumu(DateTime datum);

        [OperationContract]
        List<FiskalniRacun> SviRacuni();

        [OperationContract]
        void DodajRacun(FiskalniRacun racun);

        #endregion

    }
}
