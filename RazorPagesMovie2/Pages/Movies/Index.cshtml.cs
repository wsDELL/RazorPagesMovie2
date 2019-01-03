﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie2.Models;

namespace RazorPagesMovie2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie2.Models.RazorPagesMovie2Context _context;

        public IndexModel(RazorPagesMovie2.Models.RazorPagesMovie2Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
