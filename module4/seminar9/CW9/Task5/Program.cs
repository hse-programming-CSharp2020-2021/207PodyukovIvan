using System;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            var wikiLink = "https://ru.wikipedia.org/wiki/Шахматная_доска";
            var response = await client.GetAsync(wikiLink);
            string html = await response.Content.ReadAsStringAsync();

            foreach (Match m in Regex.Matches(html, @"<img(?'attrOther'.*?) src=""(?'src'.*?)""(?'attrOther2'.*?)>", RegexOptions.IgnoreCase))
            {
                string[] arr = m.Groups["src"].Value.Split(@"/");
                Console.WriteLine(arr[arr.Length - 1]);
            }
        }
    }
}
