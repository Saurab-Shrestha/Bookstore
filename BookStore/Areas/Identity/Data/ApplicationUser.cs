using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Required]
    public string FirstName { get; set; }

    [PersonalData]
    [Required]
    public string LastName { get; set; }

    [PersonalData]
    [Required]
    public string Address { get; set; }

    [PersonalData]
    [Required]
    public string ZipCode { get; set; }

    [PersonalData]
    [Required]
    public string City { get; set; }

    [PersonalData]
    [DataType(DataType.Date)]
    public DateTime UserCreationDate { get; set; } = DateTime.Now;
}

