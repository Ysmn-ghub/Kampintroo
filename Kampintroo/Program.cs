using System;

namespace Kampintroo
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // do not repeat yourself
            // deger tutucu = alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
