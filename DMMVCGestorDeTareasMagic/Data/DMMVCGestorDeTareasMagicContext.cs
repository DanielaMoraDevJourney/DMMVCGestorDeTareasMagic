using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DMMVCGestorDeTareasMagic.Models;

    public class DMMVCGestorDeTareasMagicContext : DbContext
    {
        public DMMVCGestorDeTareasMagicContext (DbContextOptions<DMMVCGestorDeTareasMagicContext> options)
            : base(options)
        {
        }

        public DbSet<DMMVCGestorDeTareasMagic.Models.DMCategoria> DMCategoria { get; set; } = default!;

public DbSet<DMMVCGestorDeTareasMagic.Models.DMPrioridad> DMPrioridad { get; set; } = default!;

public DbSet<DMMVCGestorDeTareasMagic.Models.DMTarea> DMTarea { get; set; } = default!;
    }
