//This is how to send a ViewModel to the frontend
//Model
public class ProductCategoryViewModel
{
    public List<ProductViewModel> Products { get; set; }
    public List<CategoryViewModel> Categories { get; set; }
}

//Controller
public IActionResult Index()
{
    var viewModel = new ProductCategoryViewModel
    {
        Products = new List<ProductViewModel>
        {
            new ProductViewModel { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new ProductViewModel { Id = 2, Name = "Phone", Price = 800, Category = "Electronics" }
        },
        Categories = new List<CategoryViewModel>
        {
            new CategoryViewModel { Id = 1, Name = "Electronics" },
            new CategoryViewModel { Id = 2, Name = "Furniture" }
        }
    };

    return View(viewModel);
}
