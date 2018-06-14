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
            DriversLogBook billsLogBook = new DriversLogBook("WZ 12345A");
            DriversLogBook johnsLogBook = new DriversLogBook("G 99ZZ");

            Entry newEntry = new Entry(DateTime.Now.Date,134.5);
      
            billsLogBook.AddNewEntry(newEntry);
            billsLogBook.WriteLogbook();
            Console.ReadKey();
        }

    }
}
