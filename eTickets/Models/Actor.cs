﻿using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
  public class Actor : IEntityBase
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "Profile Picture URL")]
    [Required(ErrorMessage = "Profile Picture is required")]
    public string ProfilePictureUrl { get; set; }

    [Display(Name = "Full Name")]
    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
    public string FullName { get; set; }

    [Display(Name = "Biography")]
    public string Bio { get; set; }

    public List<Actor_Movie> Actor_Movies { get; set; }
  }
}
