using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //algoritmanın o an için her kullanıcı için oluşturduğu anahtarlardır
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) 
            //passwordhash i doğrula
            //out olmaz çünkü bunu bizler sisteme vereceğiz
            //string password kullanıcının sisteme girmeye çalışırken girdiği sistemde kayıtlı olan şifresi
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
