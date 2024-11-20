using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pradeepweb.Data;
using pradeepweb.Model;

namespace pradeepweb.Pages.Categories;
 // [BindProperties]
public class CreateModel : PageModel
{

    public readonly ApplicationDbContext _db;
    public Category Category { get; set; }

    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(Category category)
    {
        if (category.Name == category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The Display Order is not match the name");
        }

        if (ModelState.IsValid)
        { 

        await _db.Category.AddAsync(category);
        await _db.SaveChangesAsync();
        TempData["success"] = "Category created successfully";
        return RedirectToPage("Index");
    }
        return Page();

    }
}
