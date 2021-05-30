using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class Product
    {
        int productId;
        String title;
        String description;
        double price;
        double cost;

        public Product(int id, String title)
        {
            this.productId = id;
            this.title = title;
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
