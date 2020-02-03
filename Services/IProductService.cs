using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCrm.Model;
using TinyCrm.Model.Options;

namespace TinyCrm.Services
{
    interface IProductService
    {
        bool AddProduct(AddProductOptions options);

        bool UpdateProduct(UpdateProductOptions options);

        bool GetProductById(GetProductById product);

    }
}
