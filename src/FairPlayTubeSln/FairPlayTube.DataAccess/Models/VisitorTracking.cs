﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FairPlayTube.DataAccess.Models
{
    public partial class VisitorTracking
    {
        [Key]
        public long VisitorTrackingId { get; set; }
        public long? ApplicationUserId { get; set; }
        [Required]
        [StringLength(250)]
        public string RemoteIpAddress { get; set; }
        [Required]
        [StringLength(250)]
        public string Country { get; set; }
        public DateTimeOffset VisitDateTime { get; set; }
        [Required]
        [StringLength(250)]
        public string UserAgent { get; set; }
        [Required]
        [StringLength(250)]
        public string Host { get; set; }
        [Required]
        [StringLength(250)]
        public string VisitedUrl { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty("VisitorTracking")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}