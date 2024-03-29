﻿using Core.Entities.Concrete;
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
        public static string ProductDeleted = "Ürün silindi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountofCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceed="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string OrderAdded = "Sipariş eklendi";
        public static string OrdersListed = "Siparişler listelendi";
        public static string OrderUpdated = "Sipariş güncellendi";
        public static string OrderDeleted = "Sipariş silindi";
        public static string AddressAdded = "Adres eklendi";
        public static string AddressUpdated = "Adres güncellendi";
        public static string AddressDeleted = "Adres silindi";
        public static string BasketAdded = "Sepet eklendi";
        public static string BasketUpdated = "Sepet güncellendi";
        public static string BasketDeleted = "Sepet silindi";
        public static string UserDeleted = "Kullanıcı silindi";


        //internal static string UserRegistered;
        //internal static User UserNotFound;
        //internal static User PasswordError;
        //internal static string SuccessfulLogin;
        //internal static string UserAlreadyExists;
        //internal static string AccessTokenCreated;
    }
}
