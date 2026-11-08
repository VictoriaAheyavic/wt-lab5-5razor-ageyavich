using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ageyavich.Models;
using wt_lab5_5razor_ageyavich.Data;

namespace wt_lab5_5razor_ageyavich.Pages.Products;

public class EditModel : PageModel
{
    [BindProperty]
    public Product Product { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var prod = ProductStore.Products.FirstOrDefault(x => x.Id == id);
        if (prod == null) return NotFound();
        Product = prod;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        var existing = ProductStore.Products.FirstOrDefault(x => x.Id == Product.Id);
        if (existing == null) return NotFound();

        existing.Name = Product.Name;
        existing.Category = Product.Category;
        existing.Price = Product.Price;
        existing.IsAvailable = Product.IsAvailable;

        return RedirectToPage("/Products/Index");
    }
}