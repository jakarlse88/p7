﻿namespace Poseidon.API.Models
{
    public partial class User
    {
        public short Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}
