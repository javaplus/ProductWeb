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
                ProductWeb.Models.Product tmpProduct = this.mapAPIProduct2WebProduct(product);
                productList.Add(tmpProduct);
            }

            return productList;

        }

        private ProductWeb.Models.Product mapAPIProduct2WebProduct(Product.API.Product apiProduct)
        {
            return new ProductWeb.Models.Product(apiProduct.ProductId, apiProduct.Title);
        }
    }
}
