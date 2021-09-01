using System;

namespace PageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress = System.Console.ReadLine();
            System.Net.WebClient wc = new System.Net.WebClient();
            String pageData = wc.DownloadString(adress);

            System.Console.WriteLine(pageData);
        }
    }
}
