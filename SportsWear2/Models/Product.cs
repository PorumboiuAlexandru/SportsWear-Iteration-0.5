using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsWear2.Models
{
    public enum ProductType { TShirts, Footware, Hoodies, jackets, Tracksuits }
    public enum Size { Small, Medium, Large }
    public class Product
    {
        [Key]
        public int ProductID { set; get; }
        public String Name { set; get; }
        public String Image { set; get; }
        public ProductType ProductType { set; get; }
        public String Description { set; get; }
        public Size Size { set; get; }
        public double Price { set; get; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
    public class CartItems : Product
    {
        public int Qty { get; set; }
    }
}
