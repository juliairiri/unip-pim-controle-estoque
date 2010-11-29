using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Utilidades
{
    public static class Log
    {
        public static void ToFile(string FileName, string Content)
        {
            StringBuilder content = new StringBuilder();
            string separator = "-".Replicate(80);
            string directory = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)).LocalPath;

            content.Append(separator + Environment.NewLine);
            content.Append(DateTime.Now.ToString() + Environment.NewLine);
            content.Append(separator + Environment.NewLine);
            content.Append(Content + Environment.NewLine);

            byte[] bytes = Encoding.Unicode.GetBytes(content.ToString());

            // verificar se o diretório "log" dentro da pasta bin está criado
            if (!Directory.Exists(directory + @"\log"))
                Directory.CreateDirectory(directory + @"\log");

            FileStream stream = File.Open(directory + @"\log\" + FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            stream.Seek(0, SeekOrigin.End);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
            stream.Close();
        }
    }
}
