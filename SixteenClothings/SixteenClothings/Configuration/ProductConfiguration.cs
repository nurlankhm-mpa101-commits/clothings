using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SixteenClothings.Models;

namespace SixteenClothings.Configuration;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(1024);

        builder.Property(x => x.Price).HasPrecision(10, 2);

        builder.ToTable(options =>
        {
            options.HasCheckConstraint("CK_Product_Price", "[Price]>0");
            options.HasCheckConstraint("CK_Product_Rating", "[Rating] between 0 and 5");
        } );
    }

  
}