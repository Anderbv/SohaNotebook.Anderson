using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SohaNotebook.Anderson.Entities.DbSet;

namespace SohaNotebook.Anderson.DataService.Data
{
    public class AppDbContext: IdentityDbContext 
    {
        public virtual DbSet<User> Users {  get; set; }
        public AppDbContext(DbContextOptions options): base(options) {}
    }
}
