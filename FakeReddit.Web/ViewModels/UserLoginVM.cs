﻿using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeReddit.Web.ViewModels
{
    public class UserLoginVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
