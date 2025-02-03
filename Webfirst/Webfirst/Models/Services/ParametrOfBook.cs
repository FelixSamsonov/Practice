using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Webfirst.Models;

public class ParametrOfBook
{
  
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    [StringLength(50)]
    public string? Author { get; set; }
    [StringLength(50)]
    public string? Genre { get; set; }

   
    public int Year { get; set; }
    public int Pages { get; set; }
    [Required]
    [StringLength(30)]
    public string? Language { get; set; }
}

