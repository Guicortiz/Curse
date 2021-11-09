using System;
using System.Collections.Generic;
using Curse.ContentContext;

namespace Curse
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "Orintacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "C#"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (Article article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}
