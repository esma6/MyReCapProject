using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarNameLength = "Araç ismi 2 karakterden az olamaz.";
        public static string MaintenanceTime = "Sistem bakım zamanı";
        public static string CarListed = "Araçlar listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi.";
        public static string FailAddedImageLimit="Resim ekleme limiti doldu.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
