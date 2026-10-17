using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rethi_Dobrescu_Alexandru_Lab2.Models;

namespace Rethi_Dobrescu_Alexandru_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Rethi_Dobrescu_Alexandru_Lab2Context _context;

    public IndexModel(Rethi_Dobrescu_Alexandru_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book
 .Include(b => b.Publisher)
 .ToListAsync();
    }
}
