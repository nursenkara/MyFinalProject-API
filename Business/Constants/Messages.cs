using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants

{ //static: newlenmez sabitlerde kullanılır tek instance ı oluyor
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountofCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceed="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string OrderAdded = "Sipariş eklendi";
        public static string OrdersListed = "Siparişler listelendi";
        public static string OrderUpdated = "Sipariş güncellendi";
        public static string AddressAdded = "Adres eklendi";
        public static string AddressUpdated = "Adres güncellendi";
        public static string BasketAdded = "Sepet eklendi";
        public static string BasketUpdated = "Sepet güncellendi";
        //internal static string UserRegistered;
        //internal static User UserNotFound;
        //internal static User PasswordError;
        //internal static string SuccessfulLogin;
        //internal static string UserAlreadyExists;
        //internal static string AccessTokenCreated;
    }
}
