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
            MD5 hash = MD5.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(dado);
            byte[] criptografado = hash.ComputeHash(bytes);

            return BitConverter.ToString(criptografado);
        }
    }
}
