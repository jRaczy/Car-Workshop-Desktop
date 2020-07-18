using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshopDomain
{//Klasa odwzorowuje wygląd bazy danych, wymagana do funkcjonowania DAPPERA
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Comments { get; set; }
        public string Address { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
