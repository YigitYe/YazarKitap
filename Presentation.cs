using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBOpsLayeredArch.BLL;
using DBOpsLayeredArch.Entity;

namespace DBOpsLayeredArch
{
    internal class Presentation
    {
        static void Main(string[] args)
        {
            /* menu */
            string m = "1-Kategori Listele\n";
            m += "2-Kategori Ekle\n";
            m += "3-Kategori Guncelle\n";
            m += "4-Kategori Sil\n";

            m += "0-Çıkış\n";
            int s = 1;


            do
            {
                Console.WriteLine(m);
                s = Convert.ToInt32(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        kategoriListele();
                        break;
                    case 2:
                        kategoriEkle();
                        
                        break;
                    case 3:
                        kategoriGuncelle();
                        kategoriListele();
                        break;
                    case 4:
                        kategoriSil();
                        kategoriListele();
                        break;
                }
            } while (s != 0);
            
        }

        static void kategoriSil()
        {
            Console.WriteLine("Kategori ID Giriniz");
            int id = Convert.ToInt32(Console.ReadLine());
            if(BLLKategori.kategoriSil(id)>0)
                Console.WriteLine("Kateogri Silindi");
        }

        static void kategoriListele()
        {
            Console.WriteLine("Kategori ID\t Kategori Adı");
            string s = "";
            foreach(EKategori item in BLLKategori.kategoriListele())
            {
                s += item.kategoriID + "\t" + item.kategoriAdı + "\n";
            }
            Console.WriteLine(s);
        }

        static void kategoriEkle()
        {
            Console.WriteLine("Kategori Adını Giriniz");
            string ad = Console.ReadLine();
            EKategori e = new EKategori();
            e.kategoriAdı = ad;
            if (BLLKategori.kategoriEkle(e) > 0)
            {
                Console.WriteLine("Kategori başarıyla eklendi");
            }
            kategoriListele();
        }

        static void kategoriGuncelle()
        {
            Console.WriteLine("Kategori Adını Giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Kategori ID Giriniz");
            int id = Convert.ToInt32(Console.ReadLine());

            EKategori e = new EKategori();
            e.kategoriAdı = ad;
            e.kategoriID = id;
            if (BLLKategori.kategoriGuncelle(e) > 0)
            {
                Console.WriteLine("Kategori başarıyla GÜNCELLENDİ");
            }
        }

    }
}
