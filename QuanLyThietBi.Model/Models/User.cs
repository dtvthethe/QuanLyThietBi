using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Models
{
    [Table("Users")]
    public class User : IdentityUser
    {
        [MaxLength(256)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(256)]
        [Required]
        public string Address { set; get; }

        [Required]
        public DateTime BirthDay { set; get; }

        public int IDDepartment { get; set; }

        [ForeignKey("IDDepartment")]
        public virtual Department Department { get; set; }


        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
