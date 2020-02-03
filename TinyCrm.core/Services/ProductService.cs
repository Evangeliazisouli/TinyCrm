using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCrm.core;
using TinyCrm.Core.Model;
using TinyCrm.Model.Options;

namespace TinyCrm.Core.Services
{
    public class ProductService : IProductService
    {
        private List<Product> ProductsList = new List<Product>();
        private string productid;
        private object ProductList;

        public bool AddProduct(AddProductOptions options)
        {
            if (options != null)
            {
                return false;
            }
            {
                if (!string.IsNullOrWhiteSpace(options.Id))
                {
                    return false;
                }

                if (string.IsNullOrWhiteSpace(options.Name)) {
                    return false;
                }

                var product = ProductsList
                    .Where(s => s.id.Equals(options.Id))
                    .SingleOrDefault();
                if (product != null) {
                    return false;
                }

                if (string.IsNullOrWhiteSpace(options.Name))
                {
                    return false;
                }te
                if (options.Price <= 0)
                {
                    return false;

                }
                if (options.ProductCategory == Model.ProductCategory.Invalid)
                {
                    return false;
                }

                var Product = new Product();

                

                product.id = options.Id;
                product.Name = options.Name;
                product.Price = options.Price;
                product.Category = options.ProductCategory;

                ProductsList.Add(product);

                return true;
            }
            

        }

        public bool UpdateProduct(string ProductId, Model.Options.UpdateProductOptions options)
        {
            if (string.IsNullOrWhiteSpace(productid)) {
                return false;
            }
            var product = ProductsList.Where(s => s.id.Equals(productid));


            if (options == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(options.Description)){
                return false;
            }
            if (options.Price !=null &&
                options.Price <=0)
            {
                return false;
            }
            if(options.Price != null)
            {
                if (options.Price <= 0)
                {
                    return false;

                } else {
                    product.Price = options.Price.Value;
                }
            }
            {
                return false;
            }

            if (options.Discount !=null &&
                options.Discount<0)
            {
                return false;
            }
            var Product = new Product();
            product.Discount = options.Discount;
            product.Price = options.Price;
            product.Description = options.Description;

            return true;
        }
        public bool GetProductById(string id)
        {

            if (string.IsNullOrWhiteSpace(id)) {
                return null;
            }
            return ProductList
                .SingleOrDefault(s => s.Id.Equals(id));

        }

        public bool UpdateProduct(UpdateProductOptions options)
        {
            throw new NotImplementedException();
        }

        public bool GetProductById(GetProductById product)
        {
            throw new NotImplementedException();
        }
    }
}   
