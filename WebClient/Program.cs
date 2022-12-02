using System;
using System.Collections.Generic;
using System.Text;

namespace WebClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (args.Length < 2)
                DownloadUtil.SingleConnection(args[0]);
            else
            {
                List<string> ls = new List<string>();
                foreach (var item in args)
                {
                    ls.Add(item);
                }
                DownloadUtil.MultiConnection(ls);
            }

            Console.WriteLine("Downloading process has finnished! Press any key to exit!");
            Console.ReadLine();
        }
    }
}
