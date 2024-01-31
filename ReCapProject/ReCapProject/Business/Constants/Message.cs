using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Message
    {
        // Proje kullanacağımız mesajları merkezileştirmek için Meesages classı oluşturup tüm mesajlarımızı buraya yazıyoruz
        // Bu mesajları kullanırken new'lememek ve daha verimli ve performanslı kullanım için değişkenleri static belirliyoruz

        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarIdInvalid = "Belirtilen ID'ye sahip araba bulunamadı!";
        public static string CarDeleted = "Araba silindi!";
        public static string CarUpdated = "Araba güncellendi";

        public static string BrandNameInvalid = "Marka adı en az 2 karakter olmalıdır.";
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandsListed = "Markalar başarıyla listelendi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";

        public static string ColorNameInvalid = "Renk adı en az 2 karakter olmalıdır.";
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorsListed = "Renkler başarıyla listelendi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";

        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UsersListed = "Kullanıcılar başarıyla listelendi.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomersListed = "Müşteriler başarıyla listelendi.";

        public static string RentalAdded = "Kiralama başarıyla eklendi.";
        public static string RentalDeleted = "Kiralama başarıyla silindi.";
        public static string RentalUpdated = "Kiralama başarıyla güncellendi.";
        public static string RentalsListed = "Kiralamalar başarıyla listelendi.";
        public static string CarIsNotAvailable = "Araba kiralanmaya uygun değil.";

    }
}
