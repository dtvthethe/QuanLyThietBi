using QuanLyThietBi.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Models
{
    [Table("Deliveries")]
    public class Delivery : Auditable, IIDKey
    {

        [Key]
        public int ID { get; set; }

        [StringLength(128)]
        [Column(TypeName = "nvarchar")]
        public string IDUserDelivery { get; set; }

        [ForeignKey("IDUserDelivery")]
        public User UserDelivery { get; set; }

        public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; }

    }
}