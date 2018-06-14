using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrtenbuecher
{
    class Program
    {
        static void Main(string[] args)
        {
            DriversLogBook billsLogBook = new DriversLogBook();
            DriversLogBook johnsLogBook = new DriversLogBook();

            billsLogBook.LicensePlateNumber = "WZ 12345A";
            billsLogBook.Entries = new List<Entry>();
            Entry newEntry = new Entry();
            newEntry.date = DateTime.Now.Date;
            newEntry.distance = 134.5;
            billsLogBook.Entries.Add(newEntry);
            WriteLogbook(billsLogBook);
            Console.ReadKey();
        }

        static void WriteLogbook(DriversLogBook logbook)
        {
            Console.WriteLine(logbook.LicensePlateNumber);
            foreach(Entry entry in logbook.Entries)
            {
                Console.WriteLine($"{entry.date:d}: {entry.distance} km");
            }
        }
    }
}
