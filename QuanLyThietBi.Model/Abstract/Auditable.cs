using Microsoft.AspNet.Identity.EntityFramework;
using QuanLyThietBi.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThietBi.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        private DateTime _createdDate;
        private DateTime _updatedDate;

        [StringLength(128)]
        [Column(TypeName = "nvarchar")]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate
        {
            set
            {
                _createdDate = DateTime.Now;
            }
            get
            {
                return _createdDate;
            }
        }

        public DateTime? UpdatedDate
        {
            set
            {
                _updatedDate = DateTime.Now;
            }
            get
            {
                return _updatedDate;
            }
        }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User User { get; set; }

    }
}