using System;
using System.Collections.Generic;
using System.Linq;
using Curse.ContentContext;
using Curse.SubscritionContext;

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

            var courses = new List<Course>();
            var coursesOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var coursesCsharp = new Course("Fundamentos C#", "fundamentos-C#");
            var coursesdotnet = new Course("Fundamentos .net", "fundamentos-.net");

            courses.Add(coursesOOP);
            courses.Add(coursesCsharp);
            courses.Add(coursesdotnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialist .Net", "especialist-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem2 = new CareerItem(2, "Aprenda dotnet", "", coursesCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", coursesOOP);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var PayPalSubscrition = new PayPalSubscrition();
            var student = new Student();

            student.CreateSubscrition(PayPalSubscrition);
        }
    }
}
