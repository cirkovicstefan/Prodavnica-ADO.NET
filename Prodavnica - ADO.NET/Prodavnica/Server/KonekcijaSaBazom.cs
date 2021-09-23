using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class KonekcijaSaBazom
    {
        private static SqlCommand GetSqlCommand(string sqlNaredba)
        {
            SqlConnection konekcija = new SqlConnection("Data Source=ZORANAB\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Prodavnica");
            konekcija.Open();

            return new SqlCommand(sqlNaredba, konekcija);
        }
        public static bool ExecuteNonQuerySqlCommand(string sqlNaredba)
        {
            try
            {
                SqlCommand command = GetSqlCommand(sqlNaredba);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public static object ExecuteScalarSqlCommand(string sqlNaredba)
        {
            try
            {
                SqlCommand command = GetSqlCommand(sqlNaredba);
                return command.ExecuteScalar();
            }
            catch
            {
                return new object();
            }
        }

        public static List<Artikal> SelectArtikli()
        {
            string commandSql = "SELECT * FROM artikli";
            return SelectArtikliInternal(commandSql);
        }
        public static List<Artikal> SelectArtikli(double cenaOD, double cenaDO)
        {
            string commandSql = "SELECT * FROM artikli where cena>=" + cenaOD + " and cena<=" + cenaDO; 
            return SelectArtikliInternal(commandSql);
        }
        private static List<Artikal> SelectArtikliInternal (string commandSql)
        {
            SqlCommand command = GetSqlCommand(commandSql);
            List<Artikal> retList = new List<Artikal>();

            using (SqlDataReader citac = command.ExecuteReader())
            {
                if (citac.HasRows)
                {
                    while (citac.Read())
                    {
                        Artikal artikal = new Artikal();
                        artikal.IdArtikla = citac.GetString(0);
                        artikal.Naziv = citac.GetString(1);
                        artikal.Mera = (JedinicaMere)Enum.Parse(typeof(JedinicaMere), citac.GetString(2));
                        artikal.Kolicina = (double)citac.GetDecimal(3);
                        artikal.Cena = (double)citac.GetDecimal(4);
                        retList.Add(artikal);
                    }
                }
            }
            return retList;
        }
        public static List<Korisnik> SelectKorisnici()
        {
            SqlCommand command = GetSqlCommand("SELECT * FROM korisnici");
            List<Korisnik> retList = new List<Korisnik>();

            using (SqlDataReader citac = command.ExecuteReader())
            {
                if (citac.HasRows)
                {
                    while (citac.Read())
                    {
                        Korisnik korisnik = new Korisnik();
                        korisnik.KorisnickoIme = citac.GetString(0);
                        korisnik.Lozinka = citac.GetString(1);
                        korisnik.Uloga = (Uloga)Enum.Parse(typeof(Uloga), citac.GetString(2));
                        korisnik.ImeIPrezime = citac.GetString(3);
                        retList.Add(korisnik);
                    }
                }
            }
            return retList;
        }

        public static List<FiskalniRacun> SelectRacuni()
        {
            string commandSql = "SELECT * FROM FiskalniRacun";
            return SelectRacuniInternal(commandSql);
        }
        public static List<FiskalniRacun> SelectRacuni(string imeIPrezimeKorisnika)
        {
            string commandSql = "SELECT * FROM FiskalniRacun where imeIPrezimeRadnika = '" + imeIPrezimeKorisnika + "'";
            return SelectRacuniInternal(commandSql);
        }

        public static List<FiskalniRacun> SelectRacuni(DateTime date)
        {
            string commandSql = "SELECT * FROM FiskalniRacun where CONVERT(DATE,DatumIVreme)='" + date.Date + "'";
            return SelectRacuniInternal(commandSql);
        }

        private static List<FiskalniRacun> SelectRacuniInternal(string commandSql)
        {
            SqlCommand command = GetSqlCommand(commandSql);
            List<FiskalniRacun> retList = new List<FiskalniRacun>();

            using (SqlDataReader citac = command.ExecuteReader())
            {
                if (citac.HasRows)
                {
                    while (citac.Read())
                    {
                        FiskalniRacun racun = new FiskalniRacun();
                        racun.IdRacuna = citac.GetInt32(0);
                        racun.DatumiVreme = citac.GetDateTime(1);
                        racun.ImeiPrezime = citac.GetString(2);
                        racun.IznosRacuna = (double)citac.GetDecimal(3);
                        retList.Add(racun);
                    }
                }
            }

            for (int i = 0; i < retList.Count; i++)
            {
                retList[i].ListaStavki = SelectStavkaRacuna(retList[i].IdRacuna);
            }

            return retList;
        }
        private static List<StavkaFiskalnogRacuna> SelectStavkaRacuna(int idFiskalnog)
        {
            SqlCommand command = GetSqlCommand("SELECT * FROM Stavke where idFiskalnog ="+ idFiskalnog);
            List<StavkaFiskalnogRacuna> retList = new List<StavkaFiskalnogRacuna>();

            using (SqlDataReader citac = command.ExecuteReader())
            {
                if (citac.HasRows)
                {
                    while (citac.Read())
                    {
                        StavkaFiskalnogRacuna stavka = new StavkaFiskalnogRacuna();
                        stavka.IdStavke = citac.GetInt32(0);
                        stavka.IdArtikla = citac.GetString(2);
                        stavka.Kolicina = (double) citac.GetDecimal(3);
                        retList.Add(stavka);
                    }
                }
            }
            
            return retList;
        }

    }
}
