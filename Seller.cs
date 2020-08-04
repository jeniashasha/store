using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCompany;
namespace Store
{
    class Seller
    {
        private int moneyEarned = 100;

        Newspaper newspaper = new Newspaper();
         float newPrice = 50f;

        public void SellNewspaper(Newspaper newspaper)
        {

            this.moneyEarned = (int)(moneyEarned + newspaper.GetPrice());    
        }

        public override string ToString()
        {
            return $"{ base.ToString()} money earned : {moneyEarned}";


        }
    }
}
