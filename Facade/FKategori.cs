using DBOpsLayeredArch.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBOpsLayeredArch.Facade
{
    internal class FKategori
    {
        public static int kategoriEkle(EKategori k)
        {
            Connection.connect();
            string q = "kategoriEkle";
            SqlCommand cmd = new SqlCommand(q, Connection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("kategoriAdi", k.kategoriAdı);
            int x = cmd.ExecuteNonQuery();
            Connection.disconnect();
            return x;
        }

        public static int kategoriSil(int id)
        {
            Connection.connect();
            string q = "kategoriSil";
            SqlCommand cmd = new SqlCommand(q, Connection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            int x = cmd.ExecuteNonQuery();
            Connection.disconnect();
            return x;
        }

        public static int kategoriGuncelle(EKategori k)
        {
            Connection.connect();
            string q = "kategoriGuncelle";
            SqlCommand cmd = new SqlCommand(q, Connection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", k.kategoriID);
            cmd.Parameters.AddWithValue("kategoriAdi", k.kategoriAdı);
            int x = cmd.ExecuteNonQuery();
            Connection.disconnect();
            return x;
        }

        public static EKategori kategoriBul(int id)
        {
            return null;
        }

        public static EKategori kategoriBul(string kategoriAdi)
        {
            return null;
        }

        public static List<EKategori> kategoriListele()
        {
            List<EKategori> liste = null;
            Connection.connect();
            string q = "kategoriListele";
            SqlCommand cmd = new SqlCommand(q, Connection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                liste = new List<EKategori>();
                while (r.Read())
                {
                    EKategori e = new EKategori();
                    e.kategoriID = (int)r.GetValue(0);
                    e.kategoriAdı = (string)r.GetValue(1);
                    liste.Add(e);
                }
                r.Close();
            }
            Connection.disconnect();

            return liste;
        }
    }
}
