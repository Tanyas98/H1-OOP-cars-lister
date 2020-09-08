using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_cars_lister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>
            {
                new Cars(1, "Rio", "Kia", 2006, 250000, "Red"),
                new Cars(2, "Rio", "Kia", 2007, 265000, "Black"),
                new Cars(3, "Panda", "Fiat", 2017, 256000, "Black"),
                new Cars(4, "Panda", "Fiat", 2017, 365000, "Yellow"),
                new Cars(5, "S40", "Volvo", 2018, 665000, "White"),
                new Cars(6, "S65", "Volvo", 2018, 600000, "White"),
                new Cars(7, "Gorm", "Ferrari", 2000, 4665000, "White"),
                new Cars(8, "Gorm", "Ferrari", 2018, 4665000, "White"),
            };
            List<string> nyListe = listTal.Where(number => number <= 0).ToList();
        }
    }
}
