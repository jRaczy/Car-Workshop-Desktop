using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDomain
{
    /// <summary>
    /// Klasa odwzorowuje wygląd bazy danych, wymagana do funkcjonowania DAPPERA
    /// </summary>
    public class CarVisit
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public  int Price { get; set; }
        public bool IsDone { get; set; }
    }
}
