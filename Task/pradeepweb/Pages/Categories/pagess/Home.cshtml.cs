using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using pradeepweb.Data;
using pradeepweb.Migrations;

namespace pradeepweb.Pages.Categories.pagess;

public class HomeModel : PageModel
{
    private readonly ApplicationDbContext db;

    public HomeModel(ApplicationDbContext _db)
    {
        _db = db;
    }
    public Login Login { get; set; }

    public void OnGet()
    {
    }
    public Task<IActionResult> OnPost(Login)
    {
    }
}
