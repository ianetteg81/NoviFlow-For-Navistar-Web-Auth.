using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoviFlow_For_NaviStar_Web_Authenication.Pages
{
    [Authorize(Roles = "admin")]
    [Authorize(Roles = "slt")]
    [Authorize(Roles = "depthead")]
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}