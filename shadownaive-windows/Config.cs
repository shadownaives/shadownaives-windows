using System;
using System.IO;
using System.Text;

namespace shadownaive
{
    public struct Config
    {
        public string domain;
        public string account;
        public string password;
        public string address;
        public int port;

        public bool Wirte(string file)
        {
            string str = $"{{\"listen\":\"socks://{address}:{port}\",\"proxy\":\"https://{account}:{password}@{domain}\",\"log\":\"logs/naive.log\"}}";
            File.WriteAllText(path: file, contents: str, encoding: Encoding.UTF8);
            return File.Exists(file) ? true : false;
        }
    }
}
