using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace serialization_dz
{
    class Journal
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public int PageCount { get; set; }
    }

    class JournalManager
    {
        private Journal journal;

        public void InputJournalInfo()
        {
            journal = new Journal();

            Console.Write("Enter the journal title: ");
            journal.Title = Console.ReadLine();
            Console.Write("Enter the publisher: ");
            journal.Publisher = Console.ReadLine();
            Console.Write("Enter the publication date (yyyy-MM-dd): ");
            journal.PublicationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the page count: ");
            journal.PageCount = int.Parse(Console.ReadLine());
        }

        public void DisplayJournalInfo()
        {
            Console.WriteLine("Journal Information:");
            Console.WriteLine($"Title: {journal.Title}");
            Console.WriteLine($"Publisher: {journal.Publisher}");
            Console.WriteLine($"Publication Date: {journal.PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Page Count: {journal.PageCount}");
        }

        public void SerializeJournal(string filePath)
        {
            string json = JsonSerializer.Serialize(journal);
            File.WriteAllText(filePath, json);
        }

        public void DeserializeJournal(string filePath)
        {
            string json = File.ReadAllText(filePath);
            journal = JsonSerializer.Deserialize<Journal>(json);
        }
    }


  
}
