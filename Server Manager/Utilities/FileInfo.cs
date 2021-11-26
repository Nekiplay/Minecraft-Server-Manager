using System;
using System.IO;
using System.Security.Cryptography;

namespace Server_Manager
{
    public static class FileInfoExtension
    {
        public static string MD5(this FileInfo file)
        {
            using (FileStream fs = System.IO.File.OpenRead(file.FullName))
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
