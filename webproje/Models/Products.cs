using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web;

namespace webproje.Models {

    public class Products {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Image { get; set; }
        public virtual int Price { get; set; }
    }

    public class Purchases
    {
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public virtual string NameSurname { get; set; }

        [Required(ErrorMessage = "The email adress is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public virtual string Mail { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public virtual string Gender { get; set; }
        public virtual DateTime PurchaseDate { get; set; }
    }

    public class ProductDBContext : DbContext {
        public ProductDBContext() : base ("name=DatabaseProducts") { this.Configuration.ProxyCreationEnabled = false; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Purchases> Purchases { get; set; }
    }
}