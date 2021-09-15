using System;
using System.Collections.Generic;
using System.Text;

namespace Participation
{
    class Toy
    {
        
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;
        }

        public string GetAisle()
        {
            char firstLetter = Manufacturer.ToUpper()[0];
            string priceAmt = Price.ToString().Replace(".", "");
            //bool isNumbAPeriod = false;
            //double priceAmt = Price;
            //
            //for (int i = 0; i < Price; i++)
            //{
            //    if (i == '.')
            //    {
            //        isNumbAPeriod = true;
            //        priceAmt.ToString().Trim();
            //    }
            //    else
            //    {
            //        isNumbAPeriod = false;
            //    }
            //}


            return $"{firstLetter}{priceAmt}";
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }  
}
