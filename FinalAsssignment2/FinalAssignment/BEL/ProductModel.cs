using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class ProductModel
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public int Buying_Price { get; set; }
        public int Selling_price { get; set; }
        public int Stored { get; set; }

        public virtual CategoryModel Product_Type { get; set; }
       
        //  public string CategoryName { get; set; }
        // public int  CategoryId { get; set; }

    }
}
