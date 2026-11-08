using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ageyavich.Models;
using wt_lab5_5razor_ageyavich.Data;

namespace wt_lab5_5razor_ageyavich.Pages.Products;

public class CreateModel : PageModel
{
    // [BindProperty] автоматически связывает поля из формы со свойствами объекта
    [BindProperty]
    public Product Product { get; set; } = new();

    public void OnGet()
    {
        // Вызывается при открытии страницы
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // Если есть ошибки валидации — остаемся на странице
        }

        Product.Id = ProductStore.Products.Any() 
            ? ProductStore.Products.Max(x => x.Id) + 1 
            : 1;

        ProductStore.Products.Add(Product);
        
        // Перенаправляем обратно на список
        return RedirectToPage("/Products/Index");
    }
}