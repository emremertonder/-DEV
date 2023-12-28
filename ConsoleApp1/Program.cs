using System;
using System.Collections.Generic;


class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; } //get ve set ifadeleri, bir özellik oluşturulurken onun okuma ve yazma davranışlarını belirtmemizi sağlar. 
    public string OgrenciNo { get; set; }
}

class Ogretmen
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Brans { get; set; }
    public string SicilNo { get; set; }
}

class Program
{
    static List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
    static List<Ogretmen> ogretmenListesi = new List<Ogretmen>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 - Yeni öğrenci kaydı ekle");
            Console.WriteLine("2 - Tüm öğrenci kayıtlarını göster");
            Console.WriteLine("3 - Yeni öğretmen kaydı ekle");
            Console.WriteLine("4 - Tüm öğretmen kayıtlarını göster");
            Console.WriteLine("5 - Çıkış");

            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim)) //TryParse, bir dizeyi belirli bir veri türüne dönüştürmeye çalışırken olası bir hata durumunu önlemek için kullanılan bir yöntemdir.
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                continue;
            }

            switch (secim)
            {
                case 1:
                    OgrenciKaydiEkle();
                    break;
                case 2:
                    OgrenciKayitlariniGoster();
                    break;
                case 3:                        //break, switch bloğundan çıkmak için kullanılır.
                    OgretmenKaydiEkle();       //default ise herhangi bir case durumunun uyuşmadığı durumlarda çalışacak olan varsayılan durumu belirtir.
                    break;                     //case, hangi durumun ele alındığını belirtir. 
                case 4:
                    OgretmenKayitlariniGoster();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void OgrenciKaydiEkle()
    {
        
    }

    static void OgrenciKayitlariniGoster()
    {
        
    }

    static void OgretmenKaydiEkle()
    {
        Ogretmen yeniOgretmen = new Ogretmen();

        Console.WriteLine("Öğretmen adı: ");
        yeniOgretmen.Ad = Console.ReadLine();

        Console.WriteLine("Öğretmen soyadı: ");
        yeniOgretmen.Soyad = Console.ReadLine();

        Console.WriteLine("Öğretmen branşı: ");
        yeniOgretmen.Brans = Console.ReadLine();

        Console.WriteLine("Öğretmen sicil numarası: ");
        yeniOgretmen.SicilNo = Console.ReadLine();

        ogretmenListesi.Add(yeniOgretmen);
        Console.WriteLine("Yeni öğretmen başarıyla eklendi!");
    }

    static void OgretmenKayitlariniGoster()
    {
        if (ogretmenListesi.Count == 0)
        {
            Console.WriteLine("Kayıtlı öğretmen bulunmamaktadır.");
            return;
        }

        Console.WriteLine("Kayıtlı Öğretmenler:");
        foreach (var ogretmen in ogretmenListesi) //foreach, koleksiyonlarda (diziler, listeler, sözlükler vb.) veya bazı nesnelerdeki elemanları tek tek dolaşmak için kullanılan bir döngü yapısıdır
        {
            Console.WriteLine($"Adı: {ogretmen.Ad}, Soyadı: {ogretmen.Soyad}, Branşı: {ogretmen.Brans}, Sicil No: {ogretmen.SicilNo}");
        }
    }
}
