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
            Console.ReadKey();
        }
    }
}
