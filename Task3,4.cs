using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization_dz
{
    class Article
    {
        public string Title { get; set; }
        public int CharacterCount { get; set; }
        public string Summary { get; set; }
    }

    class Journal_2
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public int PageCount { get; set; }
        public List<Article> Articles { get; set; }

        public Journal_2()
        {
            Articles = new List<Article>();
        }
    }

    class Journal_2Manager
    {
        private List<Journal_2> journals;

        public void InputJournal_2Info()
        {
            Journal_2 journal = new Journal_2();

            Console.Write("Enter the journal title: ");
            journal.Title = Console.ReadLine();
            Console.Write("Enter the publisher: ");
            journal.Publisher = Console.ReadLine();
            Console.Write("Enter the publication date (yyyy-MM-dd): ");
            journal.PublicationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the page count: ");
            journal.PageCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of articles: ");
            int articleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articleCount; i++)
            {
                Article article = new Article();

                Console.WriteLine($"Article {i + 1}");
                Console.Write("Enter the article title: ");
                article.Title = Console.ReadLine();
                Console.Write("Enter the character count: ");
                article.CharacterCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the article summary: ");
                article.Summary = Console.ReadLine();

                journal.Articles.Add(article);
            }

            journals.Add(journal);
        }

        // Методи для серіалізації/десеріалізації журналів аналогічні попереднім прикладам
    }
}
