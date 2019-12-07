using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GuestBook.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(32)]
        public string Username { get; set; }
        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }

    }
}
