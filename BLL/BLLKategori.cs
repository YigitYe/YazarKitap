using DBOpsLayeredArch.Entity;
using DBOpsLayeredArch.Facade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBOpsLayeredArch.Facade;

namespace DBOpsLayeredArch.BLL
{
    internal class BLLKategori
    {
        public static int kategoriEkle(EKategori k)
        {
            if (k.kategoriAdı.Length <= 3) return -1;
            if(k.kategoriAdı.Trim().Length == 0) return -1;
            
            return FKategori.kategoriEkle(k);
        }

        public static int kategoriSil(int id)
        {
            if (id <= 0) return -1;

            return FKategori.kategoriSil(id);
        }

        public static int kategoriGuncelle(EKategori k)
        {
            if (k.kategoriID <= 0) return -1;
            if (k.kategoriAdı.Length <= 3) return -1;
            if (k.kategoriAdı.Trim().Length == 0) return -1;

            return FKategori.kategoriGuncelle(k);
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
            return FKategori.kategoriListele() ;
        }
    }
}
