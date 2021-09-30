using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hi2.Models;

namespace Hi2.Context
{
    public class Hi2Context : DbContext
    {
        public Hi2Context (DbContextOptions<Hi2Context> options)
            : base(options)
        {
        }

        public DbSet<NoteY> NoteY { get; set; }
    }
}
