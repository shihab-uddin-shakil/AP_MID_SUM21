using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class OrderModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int User_Id { get; set; }
        public string Date { get; set; }

        public virtual User User { get; set; }
    }
}
