using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pradeepweb.Data;
using pradeepweb.Model;

namespace pradeepweb.Pages.Categories;

public class EditModel : PageModel
{
	public readonly ApplicationDbContext _db;
	public Category Category { get; set; }

	public EditModel(ApplicationDbContext db)
	{
		_db = db;
	}
	public void OnGet(int id)
	{
		Category = _db.Category.Find(id);
	}

	public async Task<IActionResult> OnPost(Category category)
	{
		if (category.Name == category.DisplayOrder.ToString())
		{
			ModelState.AddModelError("Category.Name", "The Display Order is not match the name");
		}

		if (ModelState.IsValid)
		{

			_db.Category.Update(category);
			await _db.SaveChangesAsync();
            TempData["success"] = "Category updates successfully";
            return RedirectToPage("Index");
		}
		return Page();

	}
}