using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace university.Areas.Identity.Data;

// Add profile data for application users by adding properties to the universityUser class
public class universityUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

