using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetClientValidation.Pages;

public class ContactModel : PageModel {

    [BindProperty]
    [Required]
    public string Name { get; set; } = null!;

    [BindProperty]
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    
    [BindProperty]
    [Required]
    public string Message { get; set; } = null!;
        
    public void OnGet(){

    }
}