using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace adminInterface
{
    class Class
    {
        int classvariable;
        DatabaseMain database = new DatabaseMain();
        public string Encrypt(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public int NumGenerator()
        {
            Random random = new Random();

            int num = 0;
            num = random.Next(10000, 99998);
            classvariable = num;
            return classvariable;
        }
    }
}
