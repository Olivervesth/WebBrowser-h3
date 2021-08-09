using System.Threading.Tasks;
using System;

namespace WebBrowser
{
    class Searcher
    {
        HttpSiteGetter site = new HttpSiteGetter();

        public async Task getSiteFromUrl(string url)
        {
           await site.GetFrontEnd(url);
        }

        public async Task customSearch()
        {
            Console.WriteLine("search for an animal on google");
            Console.Write("Search: ");
            string result = Console.ReadLine();
            string link = "https://www.google.com/search?q=" + result + "&btnK=Google+Search&source=hp&ei=rwYRYaKJI5qD8gKjkbqgDQ&iflsig=AINFCbYAAAAAYREUv81O2PCQ7HJDeQBs_gDA7d9FMZUH";
            await getSiteFromUrl(link);
            Console.WriteLine("\nYour link was: " + link);
            Console.ReadKey();
        }
    }
}
