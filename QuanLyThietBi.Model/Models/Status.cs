﻿using QuanLyThietBi.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Models
{
    [Table("Statuses")]
    public class Status : IIDKeyName
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
