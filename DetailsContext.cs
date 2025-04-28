using CRUD_Operations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CRUD_Operations
{
    public class DetailsContext:DbContext
    {

        
        public DetailsContext(DbContextOptions<DetailsContext> options) : base(options)
        {
            
        }
       

        // Constructor to inject the DbSettings model
       

        public DbSet<Details> details { get; set; }
      
        }
    }


