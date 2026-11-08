using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ageyavich.Models;
using wt_lab5_5razor_ageyavich.Data;

namespace wt_lab5_5razor_ageyavich.Pages.Products;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; } = new();

    public void OnGet()
    {
        // Берем данные из общего хранилища
        Products = ProductStore.Products; 
    }
}