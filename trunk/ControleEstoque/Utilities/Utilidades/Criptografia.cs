using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Utilidades
{
    public static class Criptografia
    {
        public static string Criptografar(string dado)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider(1024);
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(dado);
            byte[] criptografado = provider.Encrypt(bytes, false);

            return encoding.GetString(criptografado);
        }

        public static string Descriptografar(string dado)
        {
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider(1024);
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(dado);
            byte[] descriptografado = provider.Decrypt(bytes, false);

            return encoding.GetString(descriptografado);
        }
    }
}
