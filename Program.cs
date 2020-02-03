using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using TinyCrm.Model;

namespace TinyCrm
{
    class Program
    {
        public static decimal Price { get; private set; }

        static void Main(string[] args)
        {
           

            Log.Logger = new LoggerConfiguration().
                WriteTo.Console().
                WriteTo.File($@"{System.IO.Directory.GetCurrentDirectory()}\\logs\\log-,txt", rollingInterval: RollingInterval.Day)
                     .CreateLogger();

            Log.Error("this is an error");
            Console.ReadKey();

            var productService = new Services.ProductService();
            
            productService.AddProduct(
                new Model.Options.AddProductOptions()
                {
                    Id = "123",
                    Price = 13.33M,
                    ProductCategory = Model.ProductCategory.Cameras,
                    Name = "Camera 1"
                }); 
            productService.AddProduct(new Model.Options.AddProductOptions()
             {
         
                Id = "123",
         
                Price = 13.33M,
         
                ProductCategory = Model.ProductCategory.Cameras,
         
                Name = "camera 2"
             }); 
            productService.UpdateProduct("123",new Model.Options.UpdateProductOptions()
            {
                 Price = 22.22M
             });




        }
    }
}
