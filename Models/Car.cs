using System.ComponentModel.DataAnnotations;

namespace TPN1_GonzalezSmithTomas.Models;

public class Car{
    public string Code { get; set; }

    [Display(Name="Brand")]
    [Required]
    public string Brand { get; set; }
    [Range(1800,2023)]
    public int Year { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
}