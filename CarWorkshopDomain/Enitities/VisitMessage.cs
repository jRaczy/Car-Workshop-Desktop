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
    public class VisitMessage
    {
        
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Emial { get; set; }
        public bool IsSend { get; set; }
    }
}
