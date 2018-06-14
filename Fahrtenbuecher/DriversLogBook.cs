using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrtenbuecher
{
    /// <summary>
    /// Ein Fahrtenbuch
    /// </summary>
    /// <remarks> VORLÄUFIG public</remarks>
    public class DriversLogBook
    {
         string LicensePlateNumber;
         List<Entry> Entries;
        public DriversLogBook(string licenseNumber)
        {
            LicensePlateNumber = licenseNumber;
            Entries = new List<Entry>();
        }
        public void AddNewEntry(Entry item)
        {
            Entries.Add(item);
        }
       public  void WriteLogbook()
        {
            Console.WriteLine(LicensePlateNumber);
            foreach (Entry entry in Entries)
            {
                Console.WriteLine($"{entry.Date:d}: {entry.Distance} km");
            }
        }

    }
}
