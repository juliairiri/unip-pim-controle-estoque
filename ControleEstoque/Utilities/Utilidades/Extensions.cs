using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public static class StringExtensions
    {
        public static string Replicate(this string str, int count)
        {
            StringBuilder builder = new StringBuilder(count);
            for (int i = 1; i <= count; i++)
                builder.Append(str);

            return builder.ToString();
        }

        /// <summary>
        /// Retorna a string com zeros a esquerda
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="length">tamanho da string desejada</param>
        /// <returns>string com zeros a esquerda</returns>
        public static string StringZero(this string str, int length)
        {
            StringBuilder builder = new StringBuilder(length);
            int dif = length - str.Length;

            for (int i = 0; i < dif; i++)
                builder.Append("0");

            builder.Append(str);

            return builder.ToString();
        }
    }
}
