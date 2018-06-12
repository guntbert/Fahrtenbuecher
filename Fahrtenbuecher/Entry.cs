using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrtenbuecher
{
    /// <summary>
    /// Eine Zeile im Fahrtenbuch
    /// </summary>
    /// <remarks> Dient nur zum Speichern/Zusammenfassen 
    ///   von Informationen - daher public (nicht gekapselt)
    /// </remarks>
    public class Entry
    {
        DateTime date;
        double distance;
    }
}

// Encapsulation (Kapselung)