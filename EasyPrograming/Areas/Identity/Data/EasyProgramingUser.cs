﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EasyPrograming.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the EasyProgramingUser class
    public class EasyProgramingUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
