using Microsoft.EntityFrameworkCore;
using SixteenClothings.Models;
using SixteenClothings.Models.Common;


namespace SixteenClothings.Context;

public class AppDbContext:DbContext
{
   public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
   {
      
   }
   
   public DbSet<Product>Products { get; set; }
   public DbSet<Category>Categories { get; set; }
}