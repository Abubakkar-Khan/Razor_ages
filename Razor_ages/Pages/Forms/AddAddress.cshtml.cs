using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_ages.Models;

namespace Razor_ages.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public required AddressModel Address { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            // Save Model to DB 

            return RedirectToPage("/Index", new { City = Address.City } );
        }
    }
}
