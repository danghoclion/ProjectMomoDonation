﻿using System.ComponentModel.DataAnnotations;

namespace ProjectMomoDonation.API.DTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string[] Roles { get; set; }
        public string status { get; set; }
    }
}
