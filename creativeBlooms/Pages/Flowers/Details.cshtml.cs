using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using creativeBlooms.Models;

namespace creativeBlooms.Pages_Flowers
{
    public class DetailsModel : PageModel
    {
        private readonly creativeBloomsContext _context;

        public DetailsModel(creativeBloomsContext context)
        {
            _context = context;
        }

        public Flower Flower { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flower = await _context.Flower.FirstOrDefaultAsync(m => m.ID == id);

            if (Flower == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
