using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarDailyPriceNullException = "Araç fiyatı 0 olamaz.";
        public static string CarDeleted = "Araç sistemden silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarDetails = "Araçlar string formatında detaylı bir şekilde listelendi.";


        public static string BrandAdded = "Marka sisteme eklendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string BrandDeleted = "Marka sistemden silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";

        public static string ColorAdded = "Renk sisteme eklendi.";
        public static string ColorDeleted = "Renk sistemden silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorDetails = "Renkler string formatında detaylı bir şekilde listelendi.";
        public static string ColorNameInvalid = "Renk ismi geçersiz.";

        public static string UsersAdded = "Kullanıcı sisteme eklendi.";
        public static string UsersDeleted = "Kullanıcı sistemden silindi.";
        public static string UsersUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UsersDetails = "Kullanıcılar string formatında detaylı bir şekilde listelendi.";
        public static string UsersNameInvalid = "Kullanıcı ismi geçersiz.";

        public static string RentalAdded = "Kiralama sisteme eklendi.";
        public static string RentalNotAdded = "Kiralama sisteme eklenemedi.";
        public static string RentaslDeleted = "Kiralama sistemden silindi.";
        public static string RentalsUpdated = "Kiralama güncellendi.";
        public static string RentalsListed = "Kiralamalar listelendi.";
        public static string RentalsDetails = "Kiralamalar string formatında detaylı bir şekilde listelendi.";
        public static string RentalsNameInvalid = "Kiralama ismi geçersiz.";

        public static string CustomersAdded = "Müşteri sisteme eklendi.";
        public static string CustomerslDeleted = "Müşteri sistemden silindi.";
        public static string CustomersUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomersDetails = "Müşteriler string formatında detaylı bir şekilde listelendi.";
        public static string CustomersNameInvalid = "Müşteri ismi geçersiz.";

        public static string CarImageAdded { get; internal set; }
    }
}
