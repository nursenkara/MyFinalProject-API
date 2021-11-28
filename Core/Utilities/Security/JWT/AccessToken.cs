using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //erişim anahtarı
    public class AccessToken
    {
        //kullanıcı adı ve parola girecek biz de ona token vereceğiz
        public string Token { get; set; }//anahtar
        public DateTime Expiration { get; set; }//bitiş zamanı
    }
}
