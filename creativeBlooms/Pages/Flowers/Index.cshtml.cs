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
    public class IndexModel : PageModel
    {
        private readonly creativeBloomsContext _context;

        public IndexModel(creativeBloomsContext context)
        {
            _context = context;
        }

        public IList<Flower> Flower { get;set; }

        public async Task OnGetAsync()
        {
            Flower = await _context.Flower.ToListAsync();
        }
    }
}
