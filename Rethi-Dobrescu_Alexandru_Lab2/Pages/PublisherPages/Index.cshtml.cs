using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rethi_Dobrescu_Alexandru_Lab2.Models;

namespace Rethi_Dobrescu_Alexandru_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Rethi_Dobrescu_Alexandru_Lab2Context _context;

    public IndexModel(Rethi_Dobrescu_Alexandru_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
