using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static async Task Main()
        {
            using HttpClient client = new HttpClient();
            var wikiLink = "https://en.wikipedia.org/wiki/Main_Page";
            var response = await client.GetAsync(wikiLink);
            string htmlText = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"Скачали ответ: {htmlText.Length} символов");

            // Находим все подстроки, подходящие по шаблону:
            MatchCollection linksCollection = Regex.Matches(htmlText,
                @" href=""\/wiki\/(?<name>[\w\(\)]+)""");

            foreach (Match link in linksCollection)
                Console.WriteLine($" {link.Groups["name"].Value} : {link}");
        }
    }
}
