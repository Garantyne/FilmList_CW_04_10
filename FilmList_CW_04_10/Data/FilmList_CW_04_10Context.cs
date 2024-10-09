using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmList_CW_04_10.Models;

namespace FilmList_CW_04_10.Data
{
    public class FilmList_CW_04_10Context : DbContext
    {
        public FilmList_CW_04_10Context (DbContextOptions<FilmList_CW_04_10Context> options)
            : base(options)
        {
        }

        public DbSet<FilmList_CW_04_10.Models.Movie> Movie { get; set; } = default!;
    }
}
