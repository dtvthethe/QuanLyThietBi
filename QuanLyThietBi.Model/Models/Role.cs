using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Models
{
    [Table("Roles")]
    public class Role : IdentityRole
    {
        public Role():base()
        {

        }
    }
}
