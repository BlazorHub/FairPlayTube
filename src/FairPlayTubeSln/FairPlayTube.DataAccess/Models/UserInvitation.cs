﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FairPlayTube.DataAccess.Models
{
    public partial class UserInvitation
    {
        [Key]
        public long UserInvitationId { get; set; }
        public long InvitingApplicationUserId { get; set; }
        [Required]
        [StringLength(150)]
        public string InvitedUserEmail { get; set; }
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

        [ForeignKey(nameof(InvitingApplicationUserId))]
        [InverseProperty(nameof(ApplicationUser.UserInvitation))]
        public virtual ApplicationUser InvitingApplicationUser { get; set; }
    }
}