﻿using QuanLyThietBi.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Models
{
    [Table("DeliveryDetails")]
    public class DeliveryDetail : Auditable, IIDKey
    {

        [Key]
        public int ID { get; set; }

        public int IDDevice { get; set; }

        public int IDDelivery { get; set; }

        public int Quantity { get; set; }

        public DateTime DateExpires { get; set; }

        [ForeignKey("IDDevice")]
        public Device Device { get; set; }

        [ForeignKey("IDDelivery")]
        public Delivery Delivery { get; set; }

    }
}