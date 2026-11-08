using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_ageyavich.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Название обязательно")]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Price { get; set; }

    public bool IsAvailable { get; set; } = true;
}