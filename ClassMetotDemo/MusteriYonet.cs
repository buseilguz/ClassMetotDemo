using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriYonet
    {
        public void Ekle(musteriler musteriEkle)
        {
            Console.WriteLine(musteriEkle.ID + "no lu müşterimiz: "+ musteriEkle.MusteriAd + musteriEkle.MusteriSoyad);
        }

        public void Sil(musteriler musteriSil)

        {

            Console.WriteLine(musteriSil.ID + "no lu müşterimiz: " + musteriSil.MusteriAd + musteriSil.MusteriSoyad+ "silindi");
        }

    }
}
