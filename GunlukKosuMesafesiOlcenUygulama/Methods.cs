using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunlukKosuMesafesiOlcenUygulama
{
    public class Methods
    {
        /// <summary>
        /// Bu metot giriş cümlesini ekrana yazar.
        /// </summary>
        public void AcilisYazisiYazdir()
        {
            Console.WriteLine("************* HOŞGELDİNİZ! ************* \nBu uygulama günlük koşu mesafenizi ölçmek için tasarlandı.Haydi başlayalım!\n");
        }

        /// <summary>
        /// Bu metot kullanıcıdan adım boyunu cm cinsinden alır ve geriye int veri tipinde adım boyu değerini döndürür.
        /// </summary>
        /// <returns>Yapılan işlem sonucu geriye int tipte bir sonuç döndürür </returns>
        public int AdimBoyunuAl()
        {
            bool sayiMi = true;
            int adimBoyu = default;

            do
            {
                if (sayiMi == false)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen sadece sayı girişi yapın.\nTekrar deneyin");
                }
                else if (adimBoyu < 0)
                {
                    Console.WriteLine("0'dan küçük bir değer giremezsiniz.\nTekrar deneyin.");
                }
                else if (adimBoyu > 150)
                {
                    Console.WriteLine("Adım boyunuz 150 cm'den buyuk olamaz.\nTekrar deneyin.");
                }

                Console.Write("Ortalama adım boyunuzu tamsayı olacak şekilde santimetre(cm) cinsinden giriniz:");
                sayiMi = int.TryParse(Console.ReadLine(), out adimBoyu);

            } while (sayiMi == false || adimBoyu < 0 || adimBoyu > 150);

            return adimBoyu;

        }

        /// <summary>
        /// Bu metot kullanıcıdan adım sayısını alır ve geriye int veri tipinde adım sayısı değerini döndürür.
        /// </summary>
        /// <returns>Yapılan işlem sonucu geriye int tipte bir sonuç döndürür.</returns>
        public int DakikadaAdimSayisiniAl()
        {
            bool sayiMi = true;
            int adimSayisi = 0;

            do
            {
                if (sayiMi == false)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen sadece sayı girişi yapınız.\nTekrar deneyin");
                }
                else if (adimSayisi < 0)
                {
                    Console.WriteLine("0'dan küçük bir değer giremezsiniz.\nTekrar deneyin.");
                }
                else if (adimSayisi > 999)
                {
                    Console.WriteLine("Girdiğiniz sayi max 3 basamaklı olmalıdır.\nTekrar deneyin.");
                }

                Console.Write("Bir dakikada ortalama attığınız adım sayısını giriniz:");
                sayiMi = int.TryParse(Console.ReadLine(), out adimSayisi);

            } while (sayiMi == false || adimSayisi < 0 || adimSayisi > 999);

            return adimSayisi;

        }

        /// <summary>
        /// Bu metot kullanıcıdan koşu süresini alır ve geriye double veri tipinde koşu süresinin(dk) değerini döndürür.
        /// </summary>
        /// <returns>Yapılan işlem sonucu geriye double tipte bir sonuç döndürür</returns>
        public double KosuSuresiniAl()
        {
            bool sayiMi = true;
            int kosuSaati = default;
            double kosuDakikasi = default;
            do
            {
                if (sayiMi == false)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen sadece sayı girişi yapınız.\nTekrar deneyin");
                }
                else if (kosuSaati < 0)
                {
                    Console.WriteLine("0'dan küçük bir değer giremezsiniz.\nTekrar deneyin.");
                }
                else if (kosuSaati > 24)
                {
                    Console.WriteLine("Girdiğiniz saat değeri 0-24 arasında olmalıdır.\nTekrar deneyin.");
                }
                Console.WriteLine("Koşu sürenizi saat ve dakika olacak şekilde giriniz.");
                Console.Write("Saat?:");
                sayiMi = int.TryParse(Console.ReadLine(), out kosuSaati);

            } while (sayiMi == false || kosuSaati < 0 || kosuSaati > 24);


            do
            {
                if (sayiMi == false)
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen sadece sayı girişi yapınız.\nTekrar deneyin");
                }
                else if (kosuDakikasi < 0)
                {
                    Console.WriteLine("0'dan küçük bir değer giremezsiniz.\nTekrar deneyin.");
                }
                else if (kosuDakikasi > 60)
                {
                    Console.WriteLine("Girdiğiniz dakika değeri 0-60 arasinda olmalıdır.\nTekrar deneyin.");
                }
                Console.Write("Dakika?:");
                sayiMi = double.TryParse(Console.ReadLine(), out kosuDakikasi);

            } while (sayiMi == false || kosuDakikasi < 0 || kosuDakikasi > 60);

            double toplamKosuDakikasi = (kosuSaati * 60) + kosuDakikasi;
            return toplamKosuDakikasi;
        }

        /// <summary>
        /// 2 adet int ve 1 adet double sayıyı parametre olarak alıp koşu mesafesini hesaplayıp geriye double tipte sonuc döndürür. 
        /// </summary>
        /// <param name="adimBoyu">Hesaba dahil edilecek int tipte bir sayı girmelisiniz</param>
        /// <param name="adimSayisi">Hesaba dahil edilecek int tipte bir sayı girmelisiniz</param>
        /// <param name="toplamKosuSuresi">Hesaba dahil edilecek double tipte bir sayı girmelisiniz</param>
        /// <returns>Yapılan işlem sonucu geriye double tipte bir sonuç döndürür</returns>
        public double ToplamKosuMesafesiHesapla(int adimBoyu, int adimSayisi, double toplamKosuSuresi)
        {
            double toplamKosuMesafesi = adimBoyu * adimSayisi * toplamKosuSuresi / 100;
            return toplamKosuMesafesi;
        }

        /// <summary>
        /// 2 adet int ve 1 adet double sayıyı parametre olarak alıp koşu süresini hesaplayıp geriye double tipte sonuc döndürür. 
        /// </summary>
        /// <param name="toplamMesafe">Hesaba dahil edilecek double tipte bir sayı girmelisiniz</param>
        /// <param name="adimBoyu">Hesaba dahil edilecek int tipte bir sayı girmelisiniz</param>
        /// <param name="adimSayisi">Hesaba dahil edilecek int tipte bir sayı girmelisiniz</param>
        /// <returns>Yapılan işlem sonucu geriye double tipte bir sonuç döndürür</returns>
        public double KosuSuresiniHesapla(double toplamMesafe, int adimBoyu, int adimSayisi)
        {
            double kosuSuresi = toplamMesafe * 100 / adimSayisi / adimBoyu;
            return kosuSuresi;
        }
        /// <summary>
        /// 1 adet diziyi parametre olarak alıp koşu sürelerini ekrana yazdırır.
        /// </summary>
        /// <param name="kosuKayitlari">Ekrana yazdırılacak olan diziyi girmelisiniz</param>
        public void KosuSureleriniYazdir(double[] kosuKayitlari)
        {

            var ciftDizi = kosuKayitlari.Select((value, index) => new { Value = value, Index = index }).ToArray();
            var siraliCiftDizi = ciftDizi.OrderBy(item => item.Value).ToArray();

            Console.WriteLine("Bu sıralama hızlıdan yavaşa doğru yapılmıştır.\n********************************************");
            foreach (var cift in siraliCiftDizi)
            {
                Console.WriteLine($"{cift.Index + 1}.turu :{cift.Value} dakikada koştunuz.");
            }
        }
    }
}
