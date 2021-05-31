using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product.API;

namespace ProductWeb.Services
{
    public class ProductService
    {
        public List<ProductWeb.Models.Product> getAllProducts()
        {
            ProductServiceClient client = new ProductServiceClient();

            GetAllProductsRequest getAllProductsRequest = new GetAllProductsRequest();

            Task<GetAllProductsResponse> response = client.GetAllProductsAsync(getAllProductsRequest);

            GetAllProductsResponse productResponseList = response.Result;
            List<ProductWeb.Models.Product> productList = new List<ProductWeb.Models.Product>();

            foreach (Product.API.Product product in productResponseList.GetAllProductsResult)
            {
                ProductWeb.Models.Product tmpProduct = new ProductWeb.Models.Product(product.ProductId, product.Title);
                productList.Add(tmpProduct);
            }

            return productList;

        }
    }
}
