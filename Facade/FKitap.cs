using DBOpsLayeredArch.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBOpsLayeredArch.Facade
{
    internal class FKitap
    {
        public static int kitapEkle(EKitap k)
        {
            return 1;
        }

        public static int kitapSil(EKitap k)
        {
            return 1;
        }

        public static int kitapGuncelle(EKitap k)
        {
            return 1;
        }

        public static EKitap kitapBul(int id)
        {
            return null;
        }

        public static EKitap kitapBul(string kategoriAdi)
        {
            return null;
        }

        public static List<EKitap> kitapListele()
        {
            return null;
        }
    }
}
