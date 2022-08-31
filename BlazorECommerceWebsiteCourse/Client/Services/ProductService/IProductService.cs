namespace BlazorECommerceWebsiteCourse.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null); // if we dont have given category then we will display all the products.
        Task <ServiceResponse<Product>> GetProduct(int productId);
    }
}
