using System;
using System.IO;
using System.Security.Cryptography;

namespace HashFile
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("Укажите путь до папки: ");
            string path = Console.ReadLine();

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension == ".jar")
                {
                    string hash = ComputeMD5Checksum(info.FullName);
                    Console.WriteLine("файл: " + info.Name + " хеш: " + hash);
                }
            }
            goto start;
        }

        private static string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
    }
}
