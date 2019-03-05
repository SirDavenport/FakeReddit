using FakeReddit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeReddit.Web.ViewModels.PostVMs
{
    public class PostDetailVM
    {
        public string Email { get; set; }
        public Post Post { get; set; } = new Post();
    }
}
