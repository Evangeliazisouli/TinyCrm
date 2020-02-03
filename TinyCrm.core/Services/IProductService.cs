namespace TinyCrm.Core.Services
{
    interface IProductService
    {
        bool AddProduct(AddProductOptions options);

        bool UpdateProduct(UpdateProductOptions options);

        bool GetProductById(GetProductById product);

    }

    public class GetProductById
    {
    }

    public class UpdateProductOptions
    {
    }

    public class AddProductOptions
    {
       
    }
}
