using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //token üretecek mekanizma JWT üretecek . kullanıcı adı ve şifreyi girip web apiye gönderiliyor
        //web apide veritabanına gidip bu kullanıcının operationclaimlerine bakıp (tabi kulanıcı adı ve şifre doğruysa
        //bu işlemleri yapacak) json web token üretecek ve gönderecek.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        //HANGİ KULLANICI VE HANGİ OPERASYONLARI İÇERSİN?
    }
}
