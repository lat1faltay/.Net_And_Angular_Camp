using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
    static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();

            //musteri1.Adi = "Latif";
            //musteri1.Soyadi = "Altay";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Latif";
            musteri1.Soyadi = "Altay";
            musteri1.TcNo = "1234567890";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id= 2;
            musteri2.MusteriNo= "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
