using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employee_Management_System.Areas.Identity.Pages.Accounts
{
    public class RegisterModel : PageModel
    {
		[BindProperty]

		public InputModel Input { get; set; }
		public void OnGet()
        {
        }
    }
}
