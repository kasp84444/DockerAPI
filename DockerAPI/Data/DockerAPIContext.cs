using DockerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAPI.Data
{
    public class DockerAPIContext : DbContext
    {
        public DockerAPIContext(DbContextOptions options) : base(options)
        {
            
        }
    public DbSet<Movies> Movies { get; set; }
    }
}
