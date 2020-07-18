using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDomain
{//Klasa odwzorowuje wygląd bazy danych, wymagana do funkcjonowania DAPPERA
    public class Car
    {
        public int Id { get; set; }
        public int VIN { get; set; }
        public int YearOfProduction { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Comments { get; set; }
        public int ClientID { get; set; }
 
    }
}
