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

        public Product(int id, String title, String theDescription, double thePrice, double theCost)
        {
            this.productId = id;
            this.title = title;
            this.description = theDescription;
            this.cost = theCost;
            this.price = thePrice;
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
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
