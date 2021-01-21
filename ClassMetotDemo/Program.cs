using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            musteriler musteri1 = new musteriler();
            musteri1.ID = 123;
            musteri1.MusteriAd = "buse";
            musteri1.MusteriSoyad = "ilgüx";


            musteriler musteri2 = new musteriler();
            musteri2.ID = 124;
            musteri2.MusteriAd = "celal";
            musteri2.MusteriSoyad = "ilk";


            MusteriYonet musteriYonet = new MusteriYonet();
            musteriYonet.Ekle(musteri1);
            musteriYonet.Sil(musteri2);
        }
    }
}
