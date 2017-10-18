using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class ShopItem
    {
       private  List<Products> products = new List<Products>();

        //public ShopItem()
        //{
        //}

        //public ShopItem(string item, int price)
        //{

        //}
        public int TotalItem
        {
            get
            {
                return products.Count;
            }
        }
        public int Prices
        {
            get
            {
                return products.Sum(x =>x.TotalPrice);
            }
        }

       public void AddClass(string items, int totalPrice)
        {
            var Products = products.SingleOrDefault(x => x.ProductsName == items);
            if (Products != null)
            {
                Products.TotalPrice += totalPrice;

            }
            else 
                products.Add(new Products { ProductsName = items, TotalPrice = totalPrice });
        }
    }
}
