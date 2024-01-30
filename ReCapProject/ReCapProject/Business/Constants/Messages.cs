using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        // Proje kullanacağımız mesajları merkezileştirmek için Meesages classı oluşturup tüm mesajlarımızı buraya yazıyoruz
        // Bu mesajları kullanırken new'lememek ve daha verimli ve performanslı kullanım için değişkenleri static belirliyoruz

        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarIdInvalid = "Belirtilen ID'ye sahip araba bulunamadı!";
    }
}
