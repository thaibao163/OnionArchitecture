﻿using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}