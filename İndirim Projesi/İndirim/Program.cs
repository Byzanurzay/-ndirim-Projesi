double urun1 = UrunFiyatiAl();
double urun2 = UrunFiyatiAl();

double pahaliUrun;
if (urun1 > urun2)
{
    pahaliUrun = urun1;
}
else
{
    pahaliUrun = urun2; 
}

double ucuzUrun;
if (urun1 < urun2)
{
    ucuzUrun = urun1; 
}
else 
{
    ucuzUrun = urun2; 
}

double PahaliUrunİndirimi = pahaliUrun * 0.70;
Console.WriteLine($"En pahalı ürününüze %30 indirim uygulandı: {PahaliUrunİndirimi} TL");

double toplamFiyat = PahaliUrunİndirimi + ucuzUrun;

string cevap = EvetYadaHayirCevap();

if (cevap == "evet")
{
    double urun3 = UcuncuFiyatİndirimi();
    toplamFiyat += urun3;
}
else
{
    Console.WriteLine("Üçüncü bir ürün almak istemediniz.");
}

Console.WriteLine($"Toplam ödenecek fiyat miktarı: {toplamFiyat} TL");


    static double UrunFiyatiAl()
    {
        double fiyat;
        while (true)
        {
            Console.WriteLine("Bir ürün fiyatı giriniz:");
            string fiyatGiris = Console.ReadLine();
            if (double.TryParse(fiyatGiris, out fiyat) && fiyat > 0) 
            {
                return fiyat; 
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen 0 olmayan pozitif bir sayı giriniz.");
            }
        }
    }


    static string EvetYadaHayirCevap()
    {
        string seçim;
        while (true)
        {
            Console.WriteLine("Üçüncü bir ürün almak ister misiniz? (Evet/Hayır)"); 
            seçim = Console.ReadLine().ToLower();
            if (seçim == "evet" || seçim == "hayır")
            {
                return seçim; 
            }
            else
            {
                Console.WriteLine("Geçersiz bir yanıt girdiniz. Lütfen 'Evet' veya 'Hayır' cevaplarından birini yazınız.");
            }
        }
    }

    static double UcuncuFiyatİndirimi()
    {
          double fiyat1;
        while (true)
        {
            Console.WriteLine("Bir ürün fiyatı giriniz:");
            string fiyatGiris = Console.ReadLine();
            if (double.TryParse(fiyatGiris, out fiyat1) && fiyat1 > 0) 
            {
                fiyat1 *= 0.50;
                Console.WriteLine($"Üçüncü ürününüze %50 indirim uygulandı: {fiyat1} TL");
                return fiyat1; 
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen 0 olmayan pozitif bir sayı giriniz.");
            }
        }
    }