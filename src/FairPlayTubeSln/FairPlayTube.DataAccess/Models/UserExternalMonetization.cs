﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FairPlayTube.DataAccess.Models
{
    [Index(nameof(ApplicationUserId), nameof(MonetizationUrl), Name = "UI_UserExternalMonetization_MonetizationUrl", IsUnique = true)]
    public partial class UserExternalMonetization
    {
        [Key]
        public long UserExternalMonetizationId { get; set; }
        public long ApplicationUserId { get; set; }
        [Required]
        [StringLength(1000)]
        public string MonetizationUrl { get; set; }
        public DateTimeOffset RowCreationDateTime { get; set; }
        [Required]
        [StringLength(256)]
        public string RowCreationUser { get; set; }
        [Required]
        [StringLength(250)]
        public string SourceApplication { get; set; }
        [Required]
        [Column("OriginatorIPAddress")]
        [StringLength(100)]
        public string OriginatorIpaddress { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty("UserExternalMonetization")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}