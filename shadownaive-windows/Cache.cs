using System;
using System.IO;

namespace shadownaive
{
    public struct Cache
    {
        public string domain;
        public string account;
        public string password;
        public string address;
        public string port;

        public bool Wirte(string file)
        {
            string str = $"{address}|$|{port}|$|{domain}|$|{account}|$|{password}";
            File.WriteAllText(file, str);
            return File.Exists(file) ? true : false;
        }

        public static Cache? Read(string file)
        {
            var str = File.ReadAllText(file);
            Cache cache = new Cache();
            var temp = str.Split(new string[] { "|$|" }, StringSplitOptions.RemoveEmptyEntries);
            if (temp.Length == 5)
            {
                cache.address = temp[0];
                cache.port = temp[1];
                cache.domain = temp[2];
                cache.account = temp[3];
                cache.password = temp[4];
                return cache;
            }
            return null;
        }
    }
}
