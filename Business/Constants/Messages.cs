using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static verildiğinde new yapmaya gerek kalmaz sabitler için kullanılır
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün sistemde mevcut.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemez.";
    }
}
