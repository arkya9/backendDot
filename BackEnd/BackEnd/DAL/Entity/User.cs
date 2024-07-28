using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DAL.Entity;

[Table("users")]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("uname")]
    [StringLength(255)]
    public string? Uname { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("rid")]
    public int? Rid { get; set; }

    [Column("created_date", TypeName = "timestamp without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column("is_active")]
    [StringLength(1)]
    public string? IsActive { get; set; }
}
