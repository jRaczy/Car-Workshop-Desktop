using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastucture.Repositories
{
   public abstract class BaseRepository
    {
        //Klasa która pobiera Connection Stringa z WebConfiga
        protected  string ConncetionString
        => System.Configuration.ConfigurationManager.ConnectionStrings["MediCarDB"].ConnectionString;
    }
}
