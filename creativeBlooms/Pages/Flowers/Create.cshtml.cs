using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using creativeBlooms.Models;

namespace creativeBlooms.Pages_Flowers
{
    public class CreateModel : PageModel
    {
        private readonly creativeBloomsContext _context;

        public CreateModel(creativeBloomsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Flower Flower { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Flower.Add(Flower);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
