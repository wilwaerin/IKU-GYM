using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace webproje.Models
{
    public class Users
    {
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name ="User Name:")]
        public virtual string userName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public virtual string password { get; set; }
        public virtual string rank { get; set; }
    }

    public class UsersDBDcontext : DbContext {
        public UsersDBDcontext() : base("name=DatabaseProducts") { this.Configuration.ProxyCreationEnabled = false; }
        public DbSet<Users> Users { get; set; }
    }
}