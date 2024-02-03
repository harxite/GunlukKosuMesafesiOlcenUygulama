using GunlukKosuMesafesiOlcenUygulama;

Methods methods = new Methods();

double[] kosuKayitlari = new double[5];
methods.AcilisYazisiYazdir();
int i = 1;
int adimBoyu = default;
double toplamKosuSuresi = default;
double toplamMesafe=default;

do
{
    if (i == 1)
    {
        adimBoyu = methods.AdimBoyunuAl();
    }

    int adimSayisi = methods.DakikadaAdimSayisiniAl();

    if (i == 1)
    {
        toplamKosuSuresi = methods.KosuSuresiniAl();
        toplamMesafe = methods.ToplamKosuMesafesiHesapla(adimBoyu, adimSayisi, toplamKosuSuresi);
    }
    
    double kosuSuresi = methods.KosuSuresiniHesapla(toplamMesafe, adimBoyu, adimSayisi);

    if (i == 1)
    {
        Console.WriteLine($"Toplam koşu mesafeniz :{toplamMesafe} m dir.");
    }
    Console.WriteLine($"{i}.TUR : {toplamMesafe} m uzunlukta olan parkurdaki toplam koşu süreniz :{kosuSuresi} dk dir.");
    kosuKayitlari[0]=toplamKosuSuresi;
    if(i != 1)
    kosuKayitlari[i-1] = kosuSuresi;

    if (i < 5)
    {
        Console.WriteLine($"Harika! Haydi şimdi {i+1}. tura geçelim.");
    }

    i++;

} while (i <= 5);

Console.WriteLine("\n***TOPLAM KOŞU SÜRELERİNİZ***\n");
methods.KosuSureleriniYazdir(kosuKayitlari);
Console.WriteLine("\nTEBRİKLER! 5 turluk koşuyu başarıyla tamamladınız.");

