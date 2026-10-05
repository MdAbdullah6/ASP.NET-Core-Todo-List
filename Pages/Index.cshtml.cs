using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project1.Pages
{
    public class IndexModel : PageModel
    {
        public static List<string> TodoList = new List<string>();

        [BindProperty]
        public string NewTask { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostAdd()
        {
            if (!string.IsNullOrWhiteSpace(NewTask))
            {
                TodoList.Add(NewTask);
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int index)
        {
            if (index >= 0 && index < TodoList.Count)
            {
                TodoList.RemoveAt(index);
            }
            return RedirectToPage();
        }
    }
}