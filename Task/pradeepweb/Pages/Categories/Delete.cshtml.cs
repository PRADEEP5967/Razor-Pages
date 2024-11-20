using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pradeepweb.Data;
using pradeepweb.Model;

namespace pradeepweb.Pages.Categories;

public class DeleteModel : PageModel
{
	public readonly ApplicationDbContext _db;
	public Category Category { get; set; }

	public DeleteModel(ApplicationDbContext db)
	{
		_db = db;
	}
	public void OnGet(int id)
	{
		Category = _db.Category.Find(id);
	}

	public async Task<IActionResult> OnPost(Category category)
	{



		var categoryFromDb = _db.Category.Find(category.Id);
		if (categoryFromDb != null)
		{
			_db.Category.Remove(categoryFromDb);
			await _db.SaveChangesAsync();
            TempData["success"] = "Category delete data successfully";
            return RedirectToPage("Index");
		}
		return Page();
	}
}

