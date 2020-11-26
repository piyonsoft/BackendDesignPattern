﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entity.Dto
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

